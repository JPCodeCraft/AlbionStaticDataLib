using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class FurnitureitemCraftingrequirementsConverter : JsonConverter<FurnitureitemCraftingrequirements>
    {
        public override bool CanConvert(Type t) => t == typeof(FurnitureitemCraftingrequirements);

        public override FurnitureitemCraftingrequirements Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.StartObject:
                    var objectValue = JsonSerializer.Deserialize<StickyCraftingrequirements>(ref reader, options);
                    return new FurnitureitemCraftingrequirements { StickyCraftingrequirements = objectValue };
                case JsonTokenType.StartArray:
                    var arrayValue = JsonSerializer.Deserialize<List<PurpleCraftingrequirement>>(ref reader, options);
                    return new FurnitureitemCraftingrequirements { PurpleCraftingrequirementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type FurnitureitemCraftingrequirements");
        }

        public override void Write(Utf8JsonWriter writer, FurnitureitemCraftingrequirements value, JsonSerializerOptions options)
        {
            if (value.PurpleCraftingrequirementArray != null)
            {
                JsonSerializer.Serialize(writer, value.PurpleCraftingrequirementArray, options);
                return;
            }
            if (value.StickyCraftingrequirements != null)
            {
                JsonSerializer.Serialize(writer, value.StickyCraftingrequirements, options);
                return;
            }
            throw new Exception("Cannot marshal type FurnitureitemCraftingrequirements");
        }

        public static readonly FurnitureitemCraftingrequirementsConverter Singleton = new FurnitureitemCraftingrequirementsConverter();
    }
}
