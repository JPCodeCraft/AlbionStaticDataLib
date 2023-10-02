using System.Text.Json.Serialization;
using AlbionStaticDataLib.Json.Shared.Converters;

namespace AlbionStaticDataLib.Json.Items.Models

{
    public class UpgradeResource
    {
        [JsonPropertyName("@uniquename")]
        public string Uniquename { get; set; }

        [JsonPropertyName("@count")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Count { get; set; }
    }
}
