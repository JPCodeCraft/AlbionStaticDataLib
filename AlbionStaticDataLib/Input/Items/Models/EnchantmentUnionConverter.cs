using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class EnchantmentUnionConverter : JsonConverter<EnchantmentUnion>
    {
        public override bool CanConvert(Type t) => t == typeof(EnchantmentUnion);

        public override EnchantmentUnion Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.StartObject:
                    var objectValue = JsonSerializer.Deserialize<FluffyEnchantment>(ref reader, options);
                    return new EnchantmentUnion { FluffyEnchantment = objectValue };
                case JsonTokenType.StartArray:
                    var arrayValue = JsonSerializer.Deserialize<List<PurpleEnchantment>>(ref reader, options);
                    return new EnchantmentUnion { PurpleEnchantmentArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type EnchantmentUnion");
        }

        public override void Write(Utf8JsonWriter writer, EnchantmentUnion value, JsonSerializerOptions options)
        {
            if (value.PurpleEnchantmentArray != null)
            {
                JsonSerializer.Serialize(writer, value.PurpleEnchantmentArray, options);
                return;
            }
            if (value.FluffyEnchantment != null)
            {
                JsonSerializer.Serialize(writer, value.FluffyEnchantment, options);
                return;
            }
            throw new Exception("Cannot marshal type EnchantmentUnion");
        }

        public static readonly EnchantmentUnionConverter Singleton = new EnchantmentUnionConverter();
    }
}
