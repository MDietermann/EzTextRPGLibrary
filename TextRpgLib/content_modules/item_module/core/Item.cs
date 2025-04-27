namespace TextRpgLib.content_modules.item_module.core;

public class Item {
    
    protected Item(string name, string description, ItemTypes type, string id) {
        this.Id = $"{this.GenerateId()}:{id}";
        this.Name = name;
        this.Description = description;
        this.Type = type;
    }

    public string Id { get; }

    public string Name { get; }

    public string Description { get; }

    public ItemTypes Type { get; }

    private string GenerateId() {
        string type = this.Type.ToString();
        return BitConverter.ToString(System.Text.Encoding.UTF8.GetBytes(type));
    }
}

public enum ItemTypes {
    Equipment,
    Usable,
    Key,
    Currency
}
