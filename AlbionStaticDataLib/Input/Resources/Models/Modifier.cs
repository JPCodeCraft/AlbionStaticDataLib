using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Resources.Converters;

namespace AlbionStaticDataLib.Input.Resources.Models
{
    public class Modifier
    {
        [JsonPropertyName("@tierdifference")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Tierdifference { get; set; }

        [JsonPropertyName("@timefactor")]
        public string Timefactor { get; set; }
    }
}
