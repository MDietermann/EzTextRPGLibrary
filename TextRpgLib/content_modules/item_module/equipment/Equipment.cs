using TextRpgLib.content_modules.item_module.core;

namespace TextRpgLib.content_modules.item_module.equipment;

public abstract class Equipment : Item
{
    public int? Value { get; }
    public float? Weight { get; }
    public int? StackSize { get; }
    public int? Defense { get; }
    public List<string> Tags { get; }
    protected string EquipmentSlot { get; }

    protected Equipment(
        int? defense,
        int? value,
        float? weight,
        int? stackSize,
        List<string>? tags,
        string equipmentSlot,
        string name,
        string description,
        ItemTypes type,
        string? id = null)
        : base(name, description, type, id)
    {
        this.Defense = defense;
        this.Value = value;
        this.Weight = weight;
        this.StackSize = stackSize;
        this.Tags = tags ?? [];
        this.EquipmentSlot = equipmentSlot;
    }

    public abstract void Equip(); // Optional base method
}