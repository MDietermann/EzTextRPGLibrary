using TextRpgLib.content_modules.item_module.core;
using TextRpgLib.content_modules.item_module.currency;
using TextRpgLib.content_modules.item_module.equipment;
using TextRpgLib.content_modules.item_module.key;
using TextRpgLib.content_modules.item_module.usable;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace TextRpgLib.core_modules.yaml_integration;

/// <summary>
/// A class responsible for deserializing YAML data into a list of items.
/// </summary>
/// <typeparam name="T">The type of items to deserialize.</typeparam>
public class YamlDeserializer<T>
{
    /// <summary>
    /// Deserializes a YAML file into a list of items.
    /// </summary>
    /// <param name="filePath">The path to the YAML file to deserialize.</param>
    /// <returns>A list of deserialized items.</returns>
    public static List<Item> DeserializeItems(string filePath)
    {
        // Create a deserializer builder to configure the deserialization process.
        IDeserializer deserializer = new DeserializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance)
            // Build the deserializer with the specified configuration.
            .Build();

        System.Diagnostics.Debug.WriteLine($"StreamReader: {(new StreamReader(filePath)).ReadToEnd()}");
        
        // Create a StreamReader to read the YAML file.
        using StreamReader reader = new StreamReader(filePath);

        // Deserialize the YAML data into a list of RawItem objects.
        List<RawItem> rawItems = deserializer.Deserialize<List<RawItem>>(reader.ReadToEnd());

        // Initialize an empty list to store the deserialized items.
        List<Item> items = [];

        // Iterate over each RawItem in the list of deserialized RawItem objects.
        foreach (RawItem raw in rawItems)
        {
            // Determine the type of item to create based on the RawItem's type.
            switch (raw.Type)
            {
                case ItemTypes.Usable:
                    // Create a new Usable item with the specified properties.
                    items.Add(new Usable(
                        raw.Value ?? throw new Exception("Missing value: Value"),
                        raw.Weight ?? throw new Exception("Missing value: Weight"),
                        raw.StackSize ?? throw new Exception("Missing value: StackSize"),
                        raw.IsUsable ?? throw new Exception("Missing value: Usable"),
                        raw.Name,
                        raw.Description,
                        ItemTypes.Usable,
                        raw.Effects ?? throw new Exception("Missing value: Effects"),
                        raw.Id));
                    break;

                case ItemTypes.Equipment:
                    // Create a new Equipment item using the EquipmentFactory.
                    items.Add(EquipmentFactory.CreateEquipment(raw));
                    break;

                case ItemTypes.Key:
                    // Create a new KeyItem with the specified properties.
                    items.Add(new KeyItem(
                        raw.Weight ?? throw new Exception("Missing value: Weight"),
                        raw.Tags ?? throw new Exception("Missing value: Tags"),
                        raw.Name,
                        raw.Description,
                        ItemTypes.Key,
                        raw.Id));
                    break;

                case ItemTypes.Currency:
                    // Create a new Currency item with the specified properties.
                    items.Add(new Currency(
                        raw.Value ?? throw new Exception("Missing value: Value"),
                        raw.Weight ?? throw new Exception("Missing value: Weight"),
                        raw.StackSize ?? throw new Exception("Missing value: StackSize"),
                        raw.Tags ?? throw new Exception("Missing value: Tags"),
                        raw.Name,
                        raw.Description,
                        ItemTypes.Currency,
                        raw.Id));
                    break;

                default:
                    // Throw an exception if the RawItem's type is not supported.
                    throw new InvalidOperationException($"Unsupported item type: {raw.Type}");
            }
        }

        // Return the list of deserialized items.
        return items;
    }
}