using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Offspring
    {
        [JsonPropertyName("@chance")]
        public string Chance { get; set; }

        [JsonPropertyName("@amount")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Amount { get; set; }
    }
}
