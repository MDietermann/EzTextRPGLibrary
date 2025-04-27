using TextRpgLib.content_modules.item_module.core;

namespace TextRpgLib.content_modules.item_module.key;

public class KeyItem : Item
{
    public float Weight { get; }
    public List<string> Tags { get; }

    public KeyItem(
        float weight,
        List<string> tags,
        string name,
        string description,
        ItemTypes type,
        string? id = null)
        : base(name, description, type, id)
    {
        Weight = weight;
        Tags = tags ?? new List<string>();
    }
}

