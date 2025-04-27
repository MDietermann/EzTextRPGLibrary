using TextRpgLib.content_modules.item_module.core;

namespace TextRpgLib.content_modules.item_module.equipment.armor;

public class Armor : Equipment {
    public int? Defense { get; }

    public Armor(
        int? value, float? weight, int? stackSize, List<string>? tags, string equipmentSlot, int? defense, string name,
        string description, string? id = null)
        : base(defense, value, weight, stackSize, tags, equipmentSlot, name, description, ItemTypes.Equipment, id) {
        this.Defense = defense;
    }

    public override void Equip() {
        Console.WriteLine($"{this.Name} equipped in {this.EquipmentSlot}. Defense increased.");
    }

    public int? GetDefense() {
        return this.Defense;
    }
}
