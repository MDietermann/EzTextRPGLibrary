using TextRpgLib.content_modules.item_module.core;

namespace TextRpgLib.content_modules.item_module.equipment.weapon;

public class Weapon : Equipment {
    public DamageInfo? Damage { get; }

    public Weapon(
        int? value, float? weight, int? stackSize, List<string>? tags, string equipmentSlot, DamageInfo? damage, string name,
        string description, string? id = null)
        : base(defense: null, value, weight, stackSize, tags, equipmentSlot, name, description, ItemTypes.Equipment, id) {
        this.Damage = damage;
    }

    public override void Equip() {
        Console.WriteLine($"{this.Name} equipped in {this.EquipmentSlot}. Ready to attack!");
    }

    public int CalculateDamage() {
        return this.Damage.BaseDamage;
    }

    public bool TryCriticalHit(float luck) {
        return new Random().NextDouble() < this.Damage.CriticalChance + luck;
    }
}
