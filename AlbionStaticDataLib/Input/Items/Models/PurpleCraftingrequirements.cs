using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Items.Converters;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class PurpleCraftingrequirements
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@time")]
        public string Time { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@swaptransaction")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Swaptransaction { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("currency")]
        public Currency Currency { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@silver")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Silver { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@craftingfocus")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Craftingfocus { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@forcesinglecraft")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Forcesinglecraft { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("craftresource")]
        public CraftingrequirementCraftresourceUnion? Craftresource { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("mistcitystanding")]
        public Mistcitystanding Mistcitystanding { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@amountcrafted")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Amountcrafted { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@craftsingleperdefault")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Craftsingleperdefault { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("playerfactionstanding")]
        public Playerfactionstanding Playerfactionstanding { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@salvageitemfactor")]
        public string Salvageitemfactor { get; set; }
    }
}
