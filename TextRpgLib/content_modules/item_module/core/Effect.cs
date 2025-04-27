namespace TextRpgLib.content_modules.item_module.core;

public class Effect
{
    public string Name { get; set; }
    public float Duration { get; set; }
    public string TargetType { get; set; } // Enum: self, target, group
    public string Description { get; set; }
    public int Value { get; set; }
    public string EffectType { get; set; }

    // This is the key!
}

public enum EffectTargetTypes {
    Self,
    Target,
    Group
}

public enum EffectTypes {
    Heal,
    Damage,
    Buff,
    Debuff
}
