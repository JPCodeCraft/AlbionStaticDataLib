using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class CraftingrequirementCraftresourceUnionConverter : JsonConverter<CraftingrequirementCraftresourceUnion>
    {
        public override bool CanConvert(Type t) => t == typeof(CraftingrequirementCraftresourceUnion);

        public override CraftingrequirementCraftresourceUnion Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.StartObject:
                    var objectValue = JsonSerializer.Deserialize<CraftResource>(ref reader, options);
                    return new CraftingrequirementCraftresourceUnion { CraftingrequirementCraftresourceClass = objectValue };
                case JsonTokenType.StartArray:
                    var arrayValue = JsonSerializer.Deserialize<List<CraftResource>>(ref reader, options);
                    return new CraftingrequirementCraftresourceUnion { CraftingrequirementCraftresourceClassArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type CraftingrequirementCraftresourceUnion");
        }

        public override void Write(Utf8JsonWriter writer, CraftingrequirementCraftresourceUnion value, JsonSerializerOptions options)
        {
            if (value.CraftingrequirementCraftresourceClassArray != null)
            {
                JsonSerializer.Serialize(writer, value.CraftingrequirementCraftresourceClassArray, options);
                return;
            }
            if (value.CraftingrequirementCraftresourceClass != null)
            {
                JsonSerializer.Serialize(writer, value.CraftingrequirementCraftresourceClass, options);
                return;
            }
            throw new Exception("Cannot marshal type CraftingrequirementCraftresourceUnion");
        }

        public static readonly CraftingrequirementCraftresourceUnionConverter Singleton = new CraftingrequirementCraftresourceUnionConverter();
    }
}
