using TextRpgLib;
using TextRpgLib.content_modules.item_module.core;

namespace LibTester;

class Program {
    static void Main(string[] args) {
        string yamlFolderLocation = Path.GetFullPath("../../../Data/");

        Init init = new Init(yamlFolderLocation);
        Dictionary<string, List<Item>>? usables = init.TryGetValue("usables") as Dictionary<string, List<Item>>;
        Dictionary<string, List<Item>>? currencies = init.TryGetValue("currencies") as Dictionary<string, List<Item>>;
        List<Item> potions = usables["Potions"];
        List<Item> humanCurrency = currencies["HumanCurrency"];
        Console.WriteLine("Loading Complete!");
    }
}
