using AlbionStaticDataLib.Input.Shared.Converters;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Harvest
    {
        [JsonPropertyName("@growtime")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Growtime { get; set; }

        [JsonPropertyName("@lootlist")]
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public List<string> Lootlist { get; set; }

        [JsonPropertyName("@lootchance")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Lootchance { get; set; }

        [JsonPropertyName("@fame")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Fame { get; set; }

        [JsonPropertyName("seed")]
        public Offspring Seed { get; set; }
    }
}
