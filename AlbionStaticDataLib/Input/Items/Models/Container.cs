using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Items.Converters;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Container
    {
        [JsonPropertyName("@capacity")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Capacity { get; set; }

        [JsonPropertyName("@weightlimit")]
        public string Weightlimit { get; set; }
    }
}
