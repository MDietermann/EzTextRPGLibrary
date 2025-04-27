using TextRpgLib.content_modules.item_module.core;

namespace TextRpgLib.content_modules.item_module.equipment.accessory;

public class Accessory : Equipment {
    public List<Effect> PassiveEffects { get; }

    public Accessory(
        int? value, float? weight, int? stackSize, List<string>? tags, string equipmentSlot, List<Effect>? passiveEffects,
        string name, string description, string? id = null)
        : base(defense: null, value, weight, stackSize, tags, equipmentSlot, name, description, ItemTypes.Equipment, id) {
        this.PassiveEffects = passiveEffects ?? new List<Effect>();
    }

    public override void Equip() {
        Console.WriteLine($"{this.Name} worn on {this.EquipmentSlot}. Buffs activated!");
    }

    public IEnumerable<Effect> GetPassiveBuffs() {
        return this.PassiveEffects;
    }
}
