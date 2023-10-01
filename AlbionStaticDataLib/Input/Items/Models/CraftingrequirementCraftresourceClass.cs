using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class CraftingrequirementCraftresourceClass
    {
        [JsonPropertyName("@uniquename")]
        public string Uniquename { get; set; }

        [JsonPropertyName("@count")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Count { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@maxreturnamount")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Maxreturnamount { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@enchantmentlevel")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Enchantmentlevel { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@preservequality")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Preservequality { get; set; }
    }
}
