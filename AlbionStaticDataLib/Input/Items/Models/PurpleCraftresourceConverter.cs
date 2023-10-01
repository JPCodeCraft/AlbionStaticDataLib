using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class PurpleCraftresourceConverter : JsonConverter<PurpleCraftresource>
    {
        public override bool CanConvert(Type t) => t == typeof(PurpleCraftresource);

        public override PurpleCraftresource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.StartObject:
                    var objectValue = JsonSerializer.Deserialize<CraftingrequirementCraftresourceClass>(ref reader, options);
                    return new PurpleCraftresource { CraftingrequirementCraftresourceClass = objectValue };
                case JsonTokenType.StartArray:
                    var arrayValue = JsonSerializer.Deserialize<List<ReplacementitemElement>>(ref reader, options);
                    return new PurpleCraftresource { ReplacementitemElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type PurpleCraftresource");
        }

        public override void Write(Utf8JsonWriter writer, PurpleCraftresource value, JsonSerializerOptions options)
        {
            if (value.ReplacementitemElementArray != null)
            {
                JsonSerializer.Serialize(writer, value.ReplacementitemElementArray, options);
                return;
            }
            if (value.CraftingrequirementCraftresourceClass != null)
            {
                JsonSerializer.Serialize(writer, value.CraftingrequirementCraftresourceClass, options);
                return;
            }
            throw new Exception("Cannot marshal type PurpleCraftresource");
        }

        public static readonly PurpleCraftresourceConverter Singleton = new PurpleCraftresourceConverter();
    }
}
