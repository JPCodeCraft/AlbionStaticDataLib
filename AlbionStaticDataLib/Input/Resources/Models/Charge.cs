using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Resources.Converters;

namespace AlbionStaticDataLib.Input.Resources.Models
{
    public class Charge
    {
        [JsonPropertyName("@level")]
        public string Level { get; set; }

        [JsonPropertyName("@gfxstate")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Gfxstate { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@respawnfactormin")]
        public string Respawnfactormin { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@respawnfactormax")]
        public string Respawnfactormax { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@respawncharges")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Respawncharges { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@yield")]
        public string Yield { get; set; }
    }
}
