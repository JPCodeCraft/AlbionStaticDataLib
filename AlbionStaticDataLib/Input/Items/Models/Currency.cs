using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Currency
    {
        [JsonPropertyName("@uniquename")]
        public Uniquename Uniquename { get; set; }

        [JsonPropertyName("@amount")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Amount { get; set; }
    }
}
