using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Container
    {
        [JsonPropertyName("@capacity")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Capacity { get; set; }

        [JsonPropertyName("@weightlimit")]
        public string Weightlimit { get; set; }
    }
}
