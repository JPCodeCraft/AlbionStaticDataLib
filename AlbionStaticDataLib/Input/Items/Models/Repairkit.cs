using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Shared.Converters;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Repairkit
    {
        [JsonPropertyName("@repaircostfactor")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Repaircostfactor { get; set; }

        [JsonPropertyName("@maxtier")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Maxtier { get; set; }
    }
}
