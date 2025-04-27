namespace TextRpgLib.core_modules.yaml_integration;

public abstract class DataParser {
    public static List<T>? DeserializeItemYaml<T>(string dataFolderLocation) {
        try {
            string[] yamlFiles = Directory.GetFiles(dataFolderLocation, "*.yaml");
            List<T> allDynamicObjects = [];

            foreach (string file in yamlFiles) {
                
                string dataValue = new DirectoryInfo(dataFolderLocation).Name;
                
                string fileName = Path.GetFileNameWithoutExtension(file);
                Console.WriteLine($"Loading {Path.GetFileName(file)}");
                string yamlContent = File.ReadAllText(file);
                YamlLoader yamlLoader = new YamlLoader();
                List<T> dynamicObjects = yamlLoader.LoadYaml<T>(yamlContent, dataValue);
            }

            return allDynamicObjects;
        }
        catch (Exception ex) {
            Console.WriteLine($"Error: {ex}");
        }

        return null;
    }
}
