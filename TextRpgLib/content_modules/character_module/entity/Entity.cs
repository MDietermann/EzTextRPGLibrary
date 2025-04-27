using TextRpgLib.content_modules.inventory_module.core;

namespace TextRpgLib.content_modules.character_module.entity;

public class Entity {
    public string Id { get; }
    public string Name { get; }
    public EntityRace Race { get; }
    public EntityPrimatyStats PrimatyStats { get; }
    public RawInventory Inventory { get; }
    
    // Funktionen um Health/Mana/Stamina zu verwalten
    
    // Funktionen um Inventar zu verwalten
}
