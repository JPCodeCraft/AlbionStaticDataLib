using AlbionStaticDataLib.Json.Shared.Converters;

namespace AlbionStaticDataLib.Json.Resources.Models
{
    public class Modifier
    {
        [JsonPropertyName("@tierdifference")]
        [JsonConverter(typeof(StringToIntConverter))]
        public int Tierdifference { get; set; }

        [JsonPropertyName("@timefactor")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Timefactor { get; set; }
    }
}
