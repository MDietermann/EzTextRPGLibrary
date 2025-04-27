using TextRpgLib.content_modules.item_module.currency;
using TextRpgLib.content_modules.item_module.equipment.accessory;
using TextRpgLib.content_modules.item_module.equipment.armor;
using TextRpgLib.content_modules.item_module.equipment.weapon;
using TextRpgLib.content_modules.item_module.key;
using TextRpgLib.content_modules.item_module.usable;

namespace TextRpgLib.content_modules.inventory_module.core;

public class RawInventory {
    // Usable
    public List<Usable> Usables { get; }
    
    // Equipment
    public List<Weapon> Weapons { get; }
    public List<Armor> Armors { get; }
    public List<Accessory> Accessories { get; }
    
    // Key Items
    public List<KeyItem> KeyItems { get; }
    
    // Currency
    public List<Currency> Currencies { get; }
}
