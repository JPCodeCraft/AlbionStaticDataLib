using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Items.Converters;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Offspring
    {
        [JsonPropertyName("@chance")]
        public string Chance { get; set; }

        [JsonPropertyName("@amount")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Amount { get; set; }
    }
}
