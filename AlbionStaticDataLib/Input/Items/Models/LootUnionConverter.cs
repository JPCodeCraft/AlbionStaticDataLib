using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class LootUnionConverter : JsonConverter<LootUnion>
    {
        public override bool CanConvert(Type t) => t == typeof(LootUnion);

        public override LootUnion Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.StartObject:
                    var objectValue = JsonSerializer.Deserialize<LootElement>(ref reader, options);
                    return new LootUnion { LootElement = objectValue };
                case JsonTokenType.StartArray:
                    var arrayValue = JsonSerializer.Deserialize<List<LootElement>>(ref reader, options);
                    return new LootUnion { LootElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type LootUnion");
        }

        public override void Write(Utf8JsonWriter writer, LootUnion value, JsonSerializerOptions options)
        {
            if (value.LootElementArray != null)
            {
                JsonSerializer.Serialize(writer, value.LootElementArray, options);
                return;
            }
            if (value.LootElement != null)
            {
                JsonSerializer.Serialize(writer, value.LootElement, options);
                return;
            }
            throw new Exception("Cannot marshal type LootUnion");
        }

        public static readonly LootUnionConverter Singleton = new LootUnionConverter();
    }
}
