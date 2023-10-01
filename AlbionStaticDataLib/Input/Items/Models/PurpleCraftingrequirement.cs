using AlbionStaticDataLib.Input.Shared;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class PurpleCraftingrequirement
    {
        [JsonPropertyName("@silver")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Silver { get; set; }

        [JsonPropertyName("@time")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Time { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@craftsingleperdefault")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Craftsingleperdefault { get; set; }

        [JsonPropertyName("craftresource")]
        public CraftResource Craftresource { get; set; }
    }
}
