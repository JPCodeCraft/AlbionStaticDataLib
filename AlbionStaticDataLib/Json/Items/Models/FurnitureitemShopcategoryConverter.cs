using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Json.Items.Models

{
    internal class FurnitureitemShopcategoryConverter : JsonConverter<FurnitureitemShopcategory>
    {
        public override bool CanConvert(Type t) => t == typeof(FurnitureitemShopcategory);

        public override FurnitureitemShopcategory Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "furniture":
                    return FurnitureitemShopcategory.Furniture;
                case "trophies":
                    return FurnitureitemShopcategory.Trophies;
            }
            throw new Exception("Cannot unmarshal type FurnitureitemShopcategory");
        }

        public override void Write(Utf8JsonWriter writer, FurnitureitemShopcategory value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case FurnitureitemShopcategory.Furniture:
                    JsonSerializer.Serialize(writer, "furniture", options);
                    return;
                case FurnitureitemShopcategory.Trophies:
                    JsonSerializer.Serialize(writer, "trophies", options);
                    return;
            }
            throw new Exception("Cannot marshal type FurnitureitemShopcategory");
        }

        public static readonly FurnitureitemShopcategoryConverter Singleton = new FurnitureitemShopcategoryConverter();
    }
}
