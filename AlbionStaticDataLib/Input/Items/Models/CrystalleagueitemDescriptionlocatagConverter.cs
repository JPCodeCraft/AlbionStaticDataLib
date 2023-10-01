using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class CrystalleagueitemDescriptionlocatagConverter : JsonConverter<CrystalleagueitemDescriptionlocatag>
    {
        public override bool CanConvert(Type t) => t == typeof(CrystalleagueitemDescriptionlocatag);

        public override CrystalleagueitemDescriptionlocatag Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "@CRYSTAL_LEAGUE_TOKEN_DESC":
                    return CrystalleagueitemDescriptionlocatag.CrystalLeagueTokenDesc;
                case "@CRYSTAL_LEAGUE_TOKEN_LEGACY_DESC":
                    return CrystalleagueitemDescriptionlocatag.CrystalLeagueTokenLegacyDesc;
            }
            throw new Exception("Cannot unmarshal type CrystalleagueitemDescriptionlocatag");
        }

        public override void Write(Utf8JsonWriter writer, CrystalleagueitemDescriptionlocatag value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case CrystalleagueitemDescriptionlocatag.CrystalLeagueTokenDesc:
                    JsonSerializer.Serialize(writer, "@CRYSTAL_LEAGUE_TOKEN_DESC", options);
                    return;
                case CrystalleagueitemDescriptionlocatag.CrystalLeagueTokenLegacyDesc:
                    JsonSerializer.Serialize(writer, "@CRYSTAL_LEAGUE_TOKEN_LEGACY_DESC", options);
                    return;
            }
            throw new Exception("Cannot marshal type CrystalleagueitemDescriptionlocatag");
        }

        public static readonly CrystalleagueitemDescriptionlocatagConverter Singleton = new CrystalleagueitemDescriptionlocatagConverter();
    }
}
