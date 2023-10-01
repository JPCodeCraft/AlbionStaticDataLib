using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class UniquenameConverter : JsonConverter<Uniquename>
    {
        public override bool CanConvert(Type t) => t == typeof(Uniquename);

        public override Uniquename Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "FACTION_CAERLEON":
                    return Uniquename.FactionCaerleon;
                case "FACTION_FOREST":
                    return Uniquename.FactionForest;
                case "FACTION_HIGHLAND":
                    return Uniquename.FactionHighland;
                case "FACTION_MOUNTAIN":
                    return Uniquename.FactionMountain;
                case "FACTION_STEPPE":
                    return Uniquename.FactionSteppe;
                case "FACTION_SWAMP":
                    return Uniquename.FactionSwamp;
                case "FAVOR":
                    return Uniquename.Favor;
            }
            throw new Exception("Cannot unmarshal type Uniquename");
        }

        public override void Write(Utf8JsonWriter writer, Uniquename value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Uniquename.FactionCaerleon:
                    JsonSerializer.Serialize(writer, "FACTION_CAERLEON", options);
                    return;
                case Uniquename.FactionForest:
                    JsonSerializer.Serialize(writer, "FACTION_FOREST", options);
                    return;
                case Uniquename.FactionHighland:
                    JsonSerializer.Serialize(writer, "FACTION_HIGHLAND", options);
                    return;
                case Uniquename.FactionMountain:
                    JsonSerializer.Serialize(writer, "FACTION_MOUNTAIN", options);
                    return;
                case Uniquename.FactionSteppe:
                    JsonSerializer.Serialize(writer, "FACTION_STEPPE", options);
                    return;
                case Uniquename.FactionSwamp:
                    JsonSerializer.Serialize(writer, "FACTION_SWAMP", options);
                    return;
                case Uniquename.Favor:
                    JsonSerializer.Serialize(writer, "FAVOR", options);
                    return;
            }
            throw new Exception("Cannot marshal type Uniquename");
        }

        public static readonly UniquenameConverter Singleton = new UniquenameConverter();
    }
}
