using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Repairkit
    {
        [JsonPropertyName("@repaircostfactor")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Repaircostfactor { get; set; }

        [JsonPropertyName("@maxtier")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Maxtier { get; set; }
    }
}
