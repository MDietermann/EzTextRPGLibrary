using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace TextRpgLib.core_modules.yaml_integration;

/// <summary>
/// Class for loading YAML content into a list of dynamic objects.
/// </summary>
public class YamlLoader
{
    private readonly IDeserializer deserializer;

    /// <summary>
    /// Constructor for the YamlLoader.
    /// </summary>
    public YamlLoader()
    {
        // Set up the YAML deserializer
        this.deserializer = new DeserializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance) // If your YAML uses camelCase, this can be omitted
            .Build();
    }

    /// <summary>
    /// Loads YAML content into a list of dynamic objects.
    /// </summary>
    /// <param name="yamlContent">The YAML content to be loaded.</param>
    /// <param name="dataValue"></param>
    /// <returns>A list of dynamic objects representing the YAML content.</returns>
    public List<T> LoadYaml<T>(string yamlContent, string dataValue)
    {
        try
        {
            // Parse the YAML content
            Dictionary<string, object>? deserializedObject = this.deserializer.Deserialize<Dictionary<string, object>>(yamlContent);
            
            if (!deserializedObject.TryGetValue(dataValue, out object? value))
            {
                Console.WriteLine($"Error: {dataValue} section not found in YAML.");
                return [];
            }

            if (value is not List<object> items)
            {
                Console.WriteLine($"Error: {dataValue} is not a valid list.");
                return [];
            }

            List<T> dynamicItems = [];

            // Deserialize each item into a dynamic object
            foreach (object item in items)
            {
                if (item is Dictionary<object, object> itemDict)
                {
                    T dynamicObject = (T)Activator.CreateInstance(typeof(T), itemDict)!;
                    dynamicItems.Add(dynamicObject);
                }
                else
                {
                    Console.WriteLine($"Error: {dataValue} is not in the expected dictionary format. {item.GetType()}");
                }
            }

            return dynamicItems;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading YAML: {ex}");
            return [];
        }
    }
}