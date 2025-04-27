using TextRpgLib.content_modules.character_module.entity;
using TextRpgLib.content_modules.inventory_module.core;

namespace TextRpgLib.content_modules.character_module.core;

public class RawEntity {
    public string Id { get; }
    public string Name { get; }
    public EntityRace Race { get; }
    public EntityPrimatyStats PrimatyStats { get; }
    public EntitySecondaryStats SecondaryStats { get; } 
    public bool IsKillable { get; } = true;
    public RawInventory Inventory { get; }
}
