using System.Text.Json.Serialization;
using AlbionStaticDataLib.Json.Shared.Converters;

namespace AlbionStaticDataLib.Json.Items.Models

{
    public class Mistcitystanding
    {
        [JsonPropertyName("@minstanding")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Minstanding { get; set; }
    }
}
