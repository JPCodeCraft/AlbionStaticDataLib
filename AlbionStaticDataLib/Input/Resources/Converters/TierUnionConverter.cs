using AlbionStaticDataLib.Input.Resources.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Resources.Converters
{
    internal class TierUnionConverter : JsonConverter<TierUnion>
    {
        public override bool CanConvert(Type t) => t == typeof(TierUnion);

        public override TierUnion Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.StartObject:
                    var objectValue = JsonSerializer.Deserialize<TierElement>(ref reader, options);
                    return new TierUnion { TierElement = objectValue };
                case JsonTokenType.StartArray:
                    var arrayValue = JsonSerializer.Deserialize<List<TierElement>>(ref reader, options);
                    return new TierUnion { TierElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type TierUnion");
        }

        public override void Write(Utf8JsonWriter writer, TierUnion value, JsonSerializerOptions options)
        {
            if (value.TierElementArray != null)
            {
                JsonSerializer.Serialize(writer, value.TierElementArray, options);
                return;
            }
            if (value.TierElement != null)
            {
                JsonSerializer.Serialize(writer, value.TierElement, options);
                return;
            }
            throw new Exception("Cannot marshal type TierUnion");
        }

        public static readonly TierUnionConverter Singleton = new TierUnionConverter();
    }
}
