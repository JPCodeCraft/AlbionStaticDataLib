using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class FarmableitemShopcategoryConverter : JsonConverter<FarmableitemShopcategory>
    {
        public override bool CanConvert(Type t) => t == typeof(FarmableitemShopcategory);

        public override FarmableitemShopcategory Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "farmables":
                    return FarmableitemShopcategory.Farmables;
                case "products":
                    return FarmableitemShopcategory.Products;
            }
            throw new Exception("Cannot unmarshal type FarmableitemShopcategory");
        }

        public override void Write(Utf8JsonWriter writer, FarmableitemShopcategory value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case FarmableitemShopcategory.Farmables:
                    JsonSerializer.Serialize(writer, "farmables", options);
                    return;
                case FarmableitemShopcategory.Products:
                    JsonSerializer.Serialize(writer, "products", options);
                    return;
            }
            throw new Exception("Cannot marshal type FarmableitemShopcategory");
        }

        public static readonly FarmableitemShopcategoryConverter Singleton = new FarmableitemShopcategoryConverter();
    }
}
