using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class SimpleitemCraftingrequirementsConverter : JsonConverter<SimpleitemCraftingrequirements>
    {
        public override bool CanConvert(Type t) => t == typeof(SimpleitemCraftingrequirements);

        public override SimpleitemCraftingrequirements Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.StartObject:
                    var objectValue = JsonSerializer.Deserialize<IndigoCraftingrequirements>(ref reader, options);
                    return new SimpleitemCraftingrequirements { IndigoCraftingrequirements = objectValue };
                case JsonTokenType.StartArray:
                    var arrayValue = JsonSerializer.Deserialize<List<TentacledCraftingrequirement>>(ref reader, options);
                    return new SimpleitemCraftingrequirements { TentacledCraftingrequirementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type SimpleitemCraftingrequirements");
        }

        public override void Write(Utf8JsonWriter writer, SimpleitemCraftingrequirements value, JsonSerializerOptions options)
        {
            if (value.TentacledCraftingrequirementArray != null)
            {
                JsonSerializer.Serialize(writer, value.TentacledCraftingrequirementArray, options);
                return;
            }
            if (value.IndigoCraftingrequirements != null)
            {
                JsonSerializer.Serialize(writer, value.IndigoCraftingrequirements, options);
                return;
            }
            throw new Exception("Cannot marshal type SimpleitemCraftingrequirements");
        }

        public static readonly SimpleitemCraftingrequirementsConverter Singleton = new SimpleitemCraftingrequirementsConverter();
    }
}
