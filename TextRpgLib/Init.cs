using TextRpgLib.content_modules.item_module.core;
using TextRpgLib.core_modules.yaml_integration;

namespace TextRpgLib;

public class Init {
    private readonly string yamlDataFolderLocation;
    public Dictionary<string, Dictionary<string, List<Item>>>? Items { get; }

    public Init(string yamlDataFolderLocation) {
        this.yamlDataFolderLocation = yamlDataFolderLocation;
        this.Items = this.InitItems();
        Console.WriteLine(this.Items);
    }
    
    private Dictionary<string, Dictionary<string, List<Item>>> InitItems() {
        Dictionary<string, Dictionary<string, List<Item>>> items =
            new Dictionary<string, Dictionary<string, List<Item>>>();
        items = this.IterateFolders();
        return items;
    }

    private Dictionary<string, Dictionary<string, List<Item>>> IterateFolders() {
        Dictionary<string, Dictionary<string, List<Item>>> itemsDict =
            new Dictionary<string, Dictionary<string, List<Item>>>(); 
        
        foreach (string folder in Directory.GetDirectories(this.yamlDataFolderLocation)) {
            Console.WriteLine("------------------");
            Console.WriteLine($"Looking for yaml-files in: {Path.GetFileName(folder)}\n");
            itemsDict.Add(Path.GetFileName(folder), IterateFiles(folder));
            Console.WriteLine("------------------\n");
        }

        return itemsDict;
    }

    private static Dictionary<string, List<Item>> IterateFiles(string folder) {
        Dictionary<string, List<Item>> categoryDict = new Dictionary<string, List<Item>>();
        int counter = 1;
        foreach (string fileName in Directory.GetFiles(folder, "*.yaml").ToList()) {
            Console.WriteLine($"-> {counter++}. Found yaml-file: {Path.GetFileName(fileName)}");
            List<Item> item = YamlDeserializer<Item>.DeserializeItems(fileName);
            categoryDict.Add(Path.GetFileNameWithoutExtension(fileName), item);
        }

        return categoryDict;
    }
    
    public Dictionary<string, List<Item>>? TryGetValue(string key, out Dictionary<string, List<Item>>? value) {
        value = null;
        return this.Items?.TryGetValue(key, out value) != true 
            ? null : this.Items?[key];
    }

    public object TryGetValue(string key) {
        Dictionary<string, List<Item>> value = null;
        return this.Items?.TryGetValue(key, out value) != true 
            ? null : this.Items?[key];
    }
}
