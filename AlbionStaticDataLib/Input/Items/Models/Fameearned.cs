using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Fameearned
    {
        [JsonPropertyName("@value")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Value { get; set; }
    }
}
