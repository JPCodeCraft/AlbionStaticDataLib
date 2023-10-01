namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Craftingrequirements
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@amountcrafted")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Amountcrafted { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@craftingfocus")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Craftingfocus { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@time")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double? Time { get; set; }

        [JsonPropertyName("craftresource")]
        [JsonConverter(typeof(SingleOrArrayConverter<CraftResource>))]
        public List<CraftResource>? Craftresource { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@silver")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Silver { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@gold")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Gold { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@compensategold")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Compensategold { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@forcesinglecraft")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Forcesinglecraft { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@craftsingleperdefault")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Craftsingleperdefault { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@salvagesilverfactor")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Salvagesilverfactor { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@salvageitemfactor")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double? Salvageitemfactor { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@swaptransaction")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Swaptransaction { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@returnproductnotresource")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Returnproductnotresource { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("playerfactionstanding")]
        public Playerfactionstanding? Playerfactionstanding { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("currency")]
        public Currency? Currency { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("mistcitystanding")]
        public Mistcitystanding? Mistcitystanding { get; set; }
    }
}
