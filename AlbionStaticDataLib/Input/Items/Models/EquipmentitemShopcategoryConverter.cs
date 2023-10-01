using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class EquipmentitemShopcategoryConverter : JsonConverter<EquipmentitemShopcategory>
    {
        public override bool CanConvert(Type t) => t == typeof(EquipmentitemShopcategory);

        public override EquipmentitemShopcategory Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "accessories":
                    return EquipmentitemShopcategory.Accessories;
                case "armor":
                    return EquipmentitemShopcategory.Armor;
                case "gatherergear":
                    return EquipmentitemShopcategory.Gatherergear;
                case "melee":
                    return EquipmentitemShopcategory.Melee;
                case "offhand":
                    return EquipmentitemShopcategory.Offhand;
            }
            throw new Exception("Cannot unmarshal type EquipmentitemShopcategory");
        }

        public override void Write(Utf8JsonWriter writer, EquipmentitemShopcategory value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case EquipmentitemShopcategory.Accessories:
                    JsonSerializer.Serialize(writer, "accessories", options);
                    return;
                case EquipmentitemShopcategory.Armor:
                    JsonSerializer.Serialize(writer, "armor", options);
                    return;
                case EquipmentitemShopcategory.Gatherergear:
                    JsonSerializer.Serialize(writer, "gatherergear", options);
                    return;
                case EquipmentitemShopcategory.Melee:
                    JsonSerializer.Serialize(writer, "melee", options);
                    return;
                case EquipmentitemShopcategory.Offhand:
                    JsonSerializer.Serialize(writer, "offhand", options);
                    return;
            }
            throw new Exception("Cannot marshal type EquipmentitemShopcategory");
        }

        public static readonly EquipmentitemShopcategoryConverter Singleton = new EquipmentitemShopcategoryConverter();
    }
}
