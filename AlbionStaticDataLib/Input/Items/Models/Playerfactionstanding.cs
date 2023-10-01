using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Playerfactionstanding
    {
        [JsonPropertyName("@faction")]
        public Faction Faction { get; set; }

        [JsonPropertyName("@minstanding")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Minstanding { get; set; }
    }
}
