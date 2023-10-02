namespace AlbionStaticDataLib.Input.Items.Models

{
    public class EnchantmentsEnchantmentClass
    {
        [JsonPropertyName("@enchantmentlevel")]
        [JsonConverter(typeof(StringToIntConverter))]
        public int Enchantmentlevel { get; set; }

        [JsonPropertyName("@itempower")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Itempower { get; set; }

        [JsonPropertyName("@durability")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Durability { get; set; }

        [JsonPropertyName("craftingrequirements")]
        [JsonConverter(typeof(SingleOrArrayConverter<Craftingrequirements>))]
        public List<Craftingrequirements>? Craftingrequirements { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("upgraderequirements")]
        public Upgraderequirements Upgraderequirements { get; set; }
    }
}
