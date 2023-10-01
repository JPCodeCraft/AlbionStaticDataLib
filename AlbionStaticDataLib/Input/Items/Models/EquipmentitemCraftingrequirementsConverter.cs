using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class EquipmentitemCraftingrequirementsConverter : JsonConverter<EquipmentitemCraftingrequirements>
    {
        public override bool CanConvert(Type t) => t == typeof(EquipmentitemCraftingrequirements);

        public override EquipmentitemCraftingrequirements Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.StartObject:
                    var objectValue = JsonSerializer.Deserialize<TentacledCraftingrequirements>(ref reader, options);
                    return new EquipmentitemCraftingrequirements { TentacledCraftingrequirements = objectValue };
                case JsonTokenType.StartArray:
                    var arrayValue = JsonSerializer.Deserialize<List<FluffyCraftingrequirement>>(ref reader, options);
                    return new EquipmentitemCraftingrequirements { FluffyCraftingrequirementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type EquipmentitemCraftingrequirements");
        }

        public override void Write(Utf8JsonWriter writer, EquipmentitemCraftingrequirements value, JsonSerializerOptions options)
        {
            if (value.FluffyCraftingrequirementArray != null)
            {
                JsonSerializer.Serialize(writer, value.FluffyCraftingrequirementArray, options);
                return;
            }
            if (value.TentacledCraftingrequirements != null)
            {
                JsonSerializer.Serialize(writer, value.TentacledCraftingrequirements, options);
                return;
            }
            throw new Exception("Cannot marshal type EquipmentitemCraftingrequirements");
        }

        public static readonly EquipmentitemCraftingrequirementsConverter Singleton = new EquipmentitemCraftingrequirementsConverter();
    }
}
