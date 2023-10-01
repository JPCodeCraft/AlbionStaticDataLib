using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class ItempowerprogressiontypeEnumConverter : JsonConverter<ItempowerprogressiontypeEnum>
    {
        public override bool CanConvert(Type t) => t == typeof(ItempowerprogressiontypeEnum);

        public override ItempowerprogressiontypeEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "armor":
                    return ItempowerprogressiontypeEnum.Armor;
                case "bag":
                    return ItempowerprogressiontypeEnum.Bag;
                case "cape":
                    return ItempowerprogressiontypeEnum.Cape;
                case "head":
                    return ItempowerprogressiontypeEnum.Head;
                case "mainhand":
                    return ItempowerprogressiontypeEnum.Mainhand;
                case "offhand":
                    return ItempowerprogressiontypeEnum.Offhand;
                case "shoes":
                    return ItempowerprogressiontypeEnum.Shoes;
            }
            throw new Exception("Cannot unmarshal type ItempowerprogressiontypeEnum");
        }

        public override void Write(Utf8JsonWriter writer, ItempowerprogressiontypeEnum value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case ItempowerprogressiontypeEnum.Armor:
                    JsonSerializer.Serialize(writer, "armor", options);
                    return;
                case ItempowerprogressiontypeEnum.Bag:
                    JsonSerializer.Serialize(writer, "bag", options);
                    return;
                case ItempowerprogressiontypeEnum.Cape:
                    JsonSerializer.Serialize(writer, "cape", options);
                    return;
                case ItempowerprogressiontypeEnum.Head:
                    JsonSerializer.Serialize(writer, "head", options);
                    return;
                case ItempowerprogressiontypeEnum.Mainhand:
                    JsonSerializer.Serialize(writer, "mainhand", options);
                    return;
                case ItempowerprogressiontypeEnum.Offhand:
                    JsonSerializer.Serialize(writer, "offhand", options);
                    return;
                case ItempowerprogressiontypeEnum.Shoes:
                    JsonSerializer.Serialize(writer, "shoes", options);
                    return;
            }
            throw new Exception("Cannot marshal type ItempowerprogressiontypeEnum");
        }

        public static readonly ItempowerprogressiontypeEnumConverter Singleton = new ItempowerprogressiontypeEnumConverter();
    }
}
