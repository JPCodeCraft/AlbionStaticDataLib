using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class FactionConverter : JsonConverter<Faction>
    {
        public override bool CanConvert(Type t) => t == typeof(Faction);

        public override Faction Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "Caerleon":
                    return Faction.Caerleon;
                case "Forest":
                    return Faction.Forest;
                case "Highland":
                    return Faction.Highland;
                case "Mountain":
                    return Faction.Mountain;
                case "Steppe":
                    return Faction.Steppe;
                case "Swamp":
                    return Faction.Swamp;
            }
            throw new Exception("Cannot unmarshal type Faction");
        }

        public override void Write(Utf8JsonWriter writer, Faction value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Faction.Caerleon:
                    JsonSerializer.Serialize(writer, "Caerleon", options);
                    return;
                case Faction.Forest:
                    JsonSerializer.Serialize(writer, "Forest", options);
                    return;
                case Faction.Highland:
                    JsonSerializer.Serialize(writer, "Highland", options);
                    return;
                case Faction.Mountain:
                    JsonSerializer.Serialize(writer, "Mountain", options);
                    return;
                case Faction.Steppe:
                    JsonSerializer.Serialize(writer, "Steppe", options);
                    return;
                case Faction.Swamp:
                    JsonSerializer.Serialize(writer, "Swamp", options);
                    return;
            }
            throw new Exception("Cannot marshal type Faction");
        }

        public static readonly FactionConverter Singleton = new FactionConverter();
    }
}
