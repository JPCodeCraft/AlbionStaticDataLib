using AlbionStaticDataLib.Input.Items.Enums;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Converters

{
    internal class CurrencynameConverter : JsonConverter<CurrencyName>
    {
        public override CurrencyName Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "FACTION_CAERLEON":
                    return CurrencyName.FactionCaerleon;
                case "FACTION_FOREST":
                    return CurrencyName.FactionForest;
                case "FACTION_HIGHLAND":
                    return CurrencyName.FactionHighland;
                case "FACTION_MOUNTAIN":
                    return CurrencyName.FactionMountain;
                case "FACTION_STEPPE":
                    return CurrencyName.FactionSteppe;
                case "FACTION_SWAMP":
                    return CurrencyName.FactionSwamp;
                case "FAVOR":
                    return CurrencyName.Favor;
            }
            throw new Exception("Cannot unmarshal type Uniquename");
        }

        public override void Write(Utf8JsonWriter writer, CurrencyName value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case CurrencyName.FactionCaerleon:
                    JsonSerializer.Serialize(writer, "FACTION_CAERLEON", options);
                    return;
                case CurrencyName.FactionForest:
                    JsonSerializer.Serialize(writer, "FACTION_FOREST", options);
                    return;
                case CurrencyName.FactionHighland:
                    JsonSerializer.Serialize(writer, "FACTION_HIGHLAND", options);
                    return;
                case CurrencyName.FactionMountain:
                    JsonSerializer.Serialize(writer, "FACTION_MOUNTAIN", options);
                    return;
                case CurrencyName.FactionSteppe:
                    JsonSerializer.Serialize(writer, "FACTION_STEPPE", options);
                    return;
                case CurrencyName.FactionSwamp:
                    JsonSerializer.Serialize(writer, "FACTION_SWAMP", options);
                    return;
                case CurrencyName.Favor:
                    JsonSerializer.Serialize(writer, "FAVOR", options);
                    return;
            }
            throw new Exception("Cannot marshal type Uniquename");
        }

        public static readonly CurrencynameConverter Singleton = new CurrencynameConverter();
    }
}
