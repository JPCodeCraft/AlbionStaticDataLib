using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class ReplacementitemElement
    {
        [JsonPropertyName("@uniquename")]
        public string Uniquename { get; set; }

        [JsonPropertyName("@count")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Count { get; set; }
    }
}
