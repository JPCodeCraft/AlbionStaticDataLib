using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Shared;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class KilltrophyCraftingrequirements
    {
        [JsonPropertyName("@gold")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Gold { get; set; }

        [JsonPropertyName("@time")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Time { get; set; }
    }
}
