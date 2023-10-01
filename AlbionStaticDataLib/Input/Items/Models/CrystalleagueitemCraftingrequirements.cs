using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class CrystalleagueitemCraftingrequirements
    {
        [JsonPropertyName("@silver")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Silver { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@salvagesilverfactor")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Salvagesilverfactor { get; set; }
    }
}
