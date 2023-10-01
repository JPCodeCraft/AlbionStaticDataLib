using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class CrystalleagueitemResourcetypeConverter : JsonConverter<CrystalleagueitemResourcetype>
    {
        public override bool CanConvert(Type t) => t == typeof(CrystalleagueitemResourcetype);

        public override CrystalleagueitemResourcetype Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "CRYSTAL_LEAGUE_TOKEN")
            {
                return CrystalleagueitemResourcetype.CrystalLeagueToken;
            }
            throw new Exception("Cannot unmarshal type CrystalleagueitemResourcetype");
        }

        public override void Write(Utf8JsonWriter writer, CrystalleagueitemResourcetype value, JsonSerializerOptions options)
        {
            if (value == CrystalleagueitemResourcetype.CrystalLeagueToken)
            {
                JsonSerializer.Serialize(writer, "CRYSTAL_LEAGUE_TOKEN", options);
                return;
            }
            throw new Exception("Cannot marshal type CrystalleagueitemResourcetype");
        }

        public static readonly CrystalleagueitemResourcetypeConverter Singleton = new CrystalleagueitemResourcetypeConverter();
    }
}
