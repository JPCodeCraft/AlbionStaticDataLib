using System.Text.Json.Serialization;
using AlbionStaticDataLib.Json.Items.Enums;
using AlbionStaticDataLib.Json.Shared.Converters;

namespace AlbionStaticDataLib.Json.Items.Models

{
    public class Playerfactionstanding
    {
        [JsonPropertyName("@faction")]
        public Faction Faction { get; set; }

        [JsonPropertyName("@minstanding")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Minstanding { get; set; }
    }
}
