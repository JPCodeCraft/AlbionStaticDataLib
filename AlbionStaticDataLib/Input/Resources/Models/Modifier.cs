using AlbionStaticDataLib.Input.Shared.Converters;

namespace AlbionStaticDataLib.Input.Resources.Models
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
