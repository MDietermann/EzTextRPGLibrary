using TextRpgLib.content_modules.item_module.core;

namespace TextRpgLib.content_modules.item_module.currency;

public class Currency : Item
{
    public int Value { get; }
    public float Weight { get; }
    public int StackSize { get; }
    public List<string> Tags { get; }

    public Currency(
        int value,
        float weight,
        int stackSize,
        List<string> tags,
        string name,
        string description,
        ItemTypes type,
        string? id = null)
        : base(name, description, type, id)
    {
        this.Value = value;
        this.Weight = weight;
        this.StackSize = stackSize;
        this.Tags = tags ?? [];
    }
}