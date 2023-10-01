using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Items.Converters;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class CrystalleagueitemCraftingrequirements
    {
        [JsonPropertyName("@silver")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Silver { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@salvagesilverfactor")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Salvagesilverfactor { get; set; }
    }
}
