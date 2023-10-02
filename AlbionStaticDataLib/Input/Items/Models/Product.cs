namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Product
    {
        [JsonPropertyName("@productiontime")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Productiontime { get; set; }

        [JsonPropertyName("@actionname")]
        public string Actionname { get; set; }

        [JsonPropertyName("@lootlist")]
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> Lootlist { get; set; }

        [JsonPropertyName("@lootchance")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Lootchance { get; set; }

        [JsonPropertyName("@fame")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Fame { get; set; }
    }
}
