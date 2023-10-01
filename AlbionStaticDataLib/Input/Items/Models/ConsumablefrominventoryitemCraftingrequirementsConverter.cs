using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class ConsumablefrominventoryitemCraftingrequirementsConverter : JsonConverter<ConsumablefrominventoryitemCraftingrequirements>
    {
        public override bool CanConvert(Type t) => t == typeof(ConsumablefrominventoryitemCraftingrequirements);

        public override ConsumablefrominventoryitemCraftingrequirements Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.StartObject:
                    var objectValue = JsonSerializer.Deserialize<PurpleCraftingrequirements>(ref reader, options);
                    return new ConsumablefrominventoryitemCraftingrequirements { PurpleCraftingrequirements = objectValue };
                case JsonTokenType.StartArray:
                    var arrayValue = JsonSerializer.Deserialize<List<PurpleCraftingrequirement>>(ref reader, options);
                    return new ConsumablefrominventoryitemCraftingrequirements { PurpleCraftingrequirementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type ConsumablefrominventoryitemCraftingrequirements");
        }

        public override void Write(Utf8JsonWriter writer, ConsumablefrominventoryitemCraftingrequirements value, JsonSerializerOptions options)
        {
            if (value.PurpleCraftingrequirementArray != null)
            {
                JsonSerializer.Serialize(writer, value.PurpleCraftingrequirementArray, options);
                return;
            }
            if (value.PurpleCraftingrequirements != null)
            {
                JsonSerializer.Serialize(writer, value.PurpleCraftingrequirements, options);
                return;
            }
            throw new Exception("Cannot marshal type ConsumablefrominventoryitemCraftingrequirements");
        }

        public static readonly ConsumablefrominventoryitemCraftingrequirementsConverter Singleton = new ConsumablefrominventoryitemCraftingrequirementsConverter();
    }
}
