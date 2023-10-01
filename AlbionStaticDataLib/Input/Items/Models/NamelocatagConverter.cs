using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class NamelocatagConverter : JsonConverter<Namelocatag>
    {
        public override bool CanConvert(Type t) => t == typeof(Namelocatag);

        public override Namelocatag Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "@CRYSTAL_LEAGUE_CTY_TOKEN":
                    return Namelocatag.CrystalLeagueCtyToken;
                case "@CRYSTAL_LEAGUE_TOKEN":
                    return Namelocatag.CrystalLeagueToken;
                case "@CRYSTAL_LEAGUE_TOKEN_LEGACY":
                    return Namelocatag.CrystalLeagueTokenLegacy;
                case "@CRYSTAL_LEAGUE_TOKEN_NON_LETHAL":
                    return Namelocatag.CrystalLeagueTokenNonLethal;
            }
            throw new Exception("Cannot unmarshal type Namelocatag");
        }

        public override void Write(Utf8JsonWriter writer, Namelocatag value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Namelocatag.CrystalLeagueCtyToken:
                    JsonSerializer.Serialize(writer, "@CRYSTAL_LEAGUE_CTY_TOKEN", options);
                    return;
                case Namelocatag.CrystalLeagueToken:
                    JsonSerializer.Serialize(writer, "@CRYSTAL_LEAGUE_TOKEN", options);
                    return;
                case Namelocatag.CrystalLeagueTokenLegacy:
                    JsonSerializer.Serialize(writer, "@CRYSTAL_LEAGUE_TOKEN_LEGACY", options);
                    return;
                case Namelocatag.CrystalLeagueTokenNonLethal:
                    JsonSerializer.Serialize(writer, "@CRYSTAL_LEAGUE_TOKEN_NON_LETHAL", options);
                    return;
            }
            throw new Exception("Cannot marshal type Namelocatag");
        }

        public static readonly NamelocatagConverter Singleton = new NamelocatagConverter();
    }
}
