using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Shared;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Mistcitystanding
    {
        [JsonPropertyName("@minstanding")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Minstanding { get; set; }
    }
}
