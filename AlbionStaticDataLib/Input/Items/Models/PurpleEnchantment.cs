namespace AlbionStaticDataLib.Input.Items.Models

{
    public class PurpleEnchantment
    {
        [JsonPropertyName("@enchantmentlevel")]
        [JsonConverter(typeof(StringToIntConverter))]
        public int Enchantmentlevel { get; set; }

        [JsonPropertyName("@abilitypower")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Abilitypower { get; set; }

        [JsonPropertyName("@dummyitempower")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Dummyitempower { get; set; }

        [JsonPropertyName("@consumespell")]
        public string Consumespell { get; set; }

        [JsonPropertyName("craftingrequirements")]
        [JsonConverter(typeof(SingleOrArrayConverter<Craftingrequirements>))]
        public List<Craftingrequirements>? Craftingrequirements { get; set; }

        [JsonPropertyName("upgraderequirements")]
        public Upgraderequirements Upgraderequirements { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@nutrition")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Nutrition { get; set; }

        [JsonPropertyName("@weight")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Weight { get; set; }
    }
}
