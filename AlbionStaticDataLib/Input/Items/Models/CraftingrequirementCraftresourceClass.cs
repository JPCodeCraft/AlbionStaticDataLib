using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Shared;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class CraftingrequirementCraftresourceClass
    {
        [JsonPropertyName("@uniquename")]
        public string Uniquename { get; set; }

        [JsonPropertyName("@count")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Count { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@maxreturnamount")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Maxreturnamount { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@enchantmentlevel")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Enchantmentlevel { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@preservequality")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Preservequality { get; set; }
    }
}
