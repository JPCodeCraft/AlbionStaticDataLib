using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class PurpleEnchantment
    {
        [JsonPropertyName("@enchantmentlevel")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Enchantmentlevel { get; set; }

        [JsonPropertyName("@abilitypower")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Abilitypower { get; set; }

        [JsonPropertyName("@dummyitempower")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Dummyitempower { get; set; }

        [JsonPropertyName("@consumespell")]
        public string Consumespell { get; set; }

        [JsonPropertyName("craftingrequirements")]
        public FluffyCraftingrequirements Craftingrequirements { get; set; }

        [JsonPropertyName("upgraderequirements")]
        public Upgraderequirements Upgraderequirements { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@nutrition")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Nutrition { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@weight")]
        public string Weight { get; set; }
    }
}
