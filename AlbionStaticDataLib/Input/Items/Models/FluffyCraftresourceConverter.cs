using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class FluffyCraftresourceConverter : JsonConverter<FluffyCraftresource>
    {
        public override bool CanConvert(Type t) => t == typeof(FluffyCraftresource);

        public override FluffyCraftresource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.StartObject:
                    var objectValue = JsonSerializer.Deserialize<ReplacementitemElement>(ref reader, options);
                    return new FluffyCraftresource { ReplacementitemElement = objectValue };
                case JsonTokenType.StartArray:
                    var arrayValue = JsonSerializer.Deserialize<List<CraftResource>>(ref reader, options);
                    return new FluffyCraftresource { CraftingrequirementCraftresourceClassArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type FluffyCraftresource");
        }

        public override void Write(Utf8JsonWriter writer, FluffyCraftresource value, JsonSerializerOptions options)
        {
            if (value.CraftingrequirementCraftresourceClassArray != null)
            {
                JsonSerializer.Serialize(writer, value.CraftingrequirementCraftresourceClassArray, options);
                return;
            }
            if (value.ReplacementitemElement != null)
            {
                JsonSerializer.Serialize(writer, value.ReplacementitemElement, options);
                return;
            }
            throw new Exception("Cannot marshal type FluffyCraftresource");
        }

        public static readonly FluffyCraftresourceConverter Singleton = new FluffyCraftresourceConverter();
    }
}
