using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class WeaponCraftingrequirementsConverter : JsonConverter<WeaponCraftingrequirements>
    {
        public override bool CanConvert(Type t) => t == typeof(WeaponCraftingrequirements);

        public override WeaponCraftingrequirements Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.StartObject:
                    var objectValue = JsonSerializer.Deserialize<IndecentCraftingrequirements>(ref reader, options);
                    return new WeaponCraftingrequirements { IndecentCraftingrequirements = objectValue };
                case JsonTokenType.StartArray:
                    var arrayValue = JsonSerializer.Deserialize<List<StickyCraftingrequirement>>(ref reader, options);
                    return new WeaponCraftingrequirements { StickyCraftingrequirementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type WeaponCraftingrequirements");
        }

        public override void Write(Utf8JsonWriter writer, WeaponCraftingrequirements value, JsonSerializerOptions options)
        {
            if (value.StickyCraftingrequirementArray != null)
            {
                JsonSerializer.Serialize(writer, value.StickyCraftingrequirementArray, options);
                return;
            }
            if (value.IndecentCraftingrequirements != null)
            {
                JsonSerializer.Serialize(writer, value.IndecentCraftingrequirements, options);
                return;
            }
            throw new Exception("Cannot marshal type WeaponCraftingrequirements");
        }

        public static readonly WeaponCraftingrequirementsConverter Singleton = new WeaponCraftingrequirementsConverter();
    }
}
