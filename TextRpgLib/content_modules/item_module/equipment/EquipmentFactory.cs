using TextRpgLib.content_modules.item_module.core;
using TextRpgLib.content_modules.item_module.equipment.accessory;
using TextRpgLib.content_modules.item_module.equipment.armor;
using TextRpgLib.content_modules.item_module.equipment.weapon;

namespace TextRpgLib.content_modules.item_module.equipment;

public static class EquipmentFactory
{
    public static Equipment? CreateEquipment(RawItem raw) {
        if (raw.EquipmentSlot != null) {
            string slot = raw.EquipmentSlot.ToLower();

            return slot switch
            {
                "weapon" or "offhand" => new Weapon(
                    raw.Value ,
                    raw.Weight,
                    raw.StackSize,
                    raw.Tags,
                    raw.EquipmentSlot,
                    raw.Damage,
                    raw.Name,
                    raw.Description,
                    raw.Id),

                "head" or "chest" or "legs" or "hands" or "feet" => new Armor(
                    raw.Value,
                    raw.Weight,
                    raw.StackSize,
                    raw.Tags,
                    raw.EquipmentSlot,
                    raw.Defense,
                    raw.Name,
                    raw.Description,
                    raw.Id),

                "amulet" or "ring" or "necklace" => new Accessory(
                    raw.Value,
                    raw.Weight,
                    raw.StackSize,
                    raw.Tags,
                    raw.EquipmentSlot,
                    raw.Effects,
                    raw.Name,
                    raw.Description,
                    raw.Id),

                var _ => throw new InvalidOperationException($"Unknown equipmentSlot: {slot}")
            };
        }

        return null;
    }
}
