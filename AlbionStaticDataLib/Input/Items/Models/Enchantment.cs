namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Enchantment
    {
        [JsonPropertyName("@enchantmentlevel")]
        [JsonConverter(typeof(StringToIntConverter))]
        public int Enchantmentlevel { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@abilitypower")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Abilitypower { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@dummyitempower")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Dummyitempower { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@itempower")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Itempower { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@durability")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Durability { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@consumespell")]
        public string? Consumespell { get; set; }

        [JsonPropertyName("craftingrequirements")]
        [JsonConverter(typeof(SingleOrArrayConverter<Craftingrequirements>))]
        public List<Craftingrequirements>? Craftingrequirements { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("upgraderequirements")]
        public Upgraderequirements? Upgraderequirements { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@nutrition")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Nutrition { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@weight")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double? Weight { get; set; }
    }
}
