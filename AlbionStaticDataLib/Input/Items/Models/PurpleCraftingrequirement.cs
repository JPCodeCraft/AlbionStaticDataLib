using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class PurpleCraftingrequirement
    {
        [JsonPropertyName("@silver")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Silver { get; set; }

        [JsonPropertyName("@time")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Time { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@craftsingleperdefault")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Craftsingleperdefault { get; set; }

        [JsonPropertyName("craftresource")]
        public CraftingrequirementCraftresourceClass Craftresource { get; set; }
    }
}
