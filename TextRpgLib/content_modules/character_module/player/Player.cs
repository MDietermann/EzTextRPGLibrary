using TextRpgLib.content_modules.character_module.entity;
using TextRpgLib.content_modules.inventory_module.core;

namespace TextRpgLib.content_modules.character_module.player;

public class Player : Entity {
    public string Id { get; }
    public string Name { get; }
    public EntityRace Race { get; }
    public EntityPrimatyStats PrimaryStats { get; }
    public EntitySecondaryStats SecondaryStats { get; }
    public RawInventory Inventory { get; }
    
    // Funktionen um Health/Mana/Stamina zu verwalten
    
    
    // Funktionen um Inventar zu verwalten
}
