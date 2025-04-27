using TextRpgLib.content_modules.item_module.core;

namespace TextRpgLib.content_modules.item_module.usable;

public class Usable(
    int value,
    float weight,
    int stackSize,
    bool usable,
    string name,
    string description,
    ItemTypes type,
    List<Effect> effects,
    string? id = null)
    : Item(name, description, type, id) {
    public int Value { get; } = value;
    public float Weight { get; } = weight;
    public int StackSize { get; } = stackSize;
    public bool IsUsable { get; set; } = usable;
    public List<Effect> Effects { get; } = effects;
}
