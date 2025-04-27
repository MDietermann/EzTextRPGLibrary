using TextRpgLib.core_modules.yaml_integration;

namespace TextRpgLib;

public abstract class ItemLoader<T> {
    public static List<T>? LoadData(string itemsFolderLocation) {
        List<T>? data = DataParser.DeserializeItemYaml<T>(itemsFolderLocation);
        return data;
    }
}
