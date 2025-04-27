namespace TextRpgLib.content_modules.item_module.core;

public class RawItem {
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ItemTypes Type { get; set; }
    public int? Value { get; set; }
    public float? Weight { get; set; }
    public int? StackSize { get; set; }
    public List<string> Tags { get; set; }
    public bool? IsUsable { get; set; }
    public string EquipmentSlot { get; set; }
    public DamageInfo Damage { get; set; }
    public List<Effect> Effects { get; set; }
    public int? Defense { get; set; }  // For Armor
    public RawItem()
    {
        // Initialize the lists to avoid null reference exceptions
        this.Tags = [];
    }
}
