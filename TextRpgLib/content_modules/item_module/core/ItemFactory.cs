using TextRpgLib.content_modules.item_module.usable;

namespace TextRpgLib.content_modules.item_module.core;

public static class ItemFactory {
    public static Item CreateFromRaw(RawItem raw) {
        return raw.Type switch {
            ItemTypes.Usable => new Usable(raw.Value ?? 0, raw.Weight ?? 0, raw.StackSize ?? 0, raw.IsUsable ?? false, raw.Name,
                raw.Description, raw.Type, raw.Effects ?? [], raw.Id),
            ItemTypes.Equipment => throw new NotImplementedException(),
            ItemTypes.Key => throw new NotImplementedException(),
            ItemTypes.Currency => throw new NotImplementedException(),
            var _ => throw new Exception(
                "Given Type currently not supported. Please refer to the given Enums in TextRpgLib/core_modules/yaml_integration/schema_definitions/item.schema.yaml")
        };
    }
}
