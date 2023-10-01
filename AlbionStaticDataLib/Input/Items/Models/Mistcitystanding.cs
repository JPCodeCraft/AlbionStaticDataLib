using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Mistcitystanding
    {
        [JsonPropertyName("@minstanding")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Minstanding { get; set; }
    }
}
