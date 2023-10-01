using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Items.Converters;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Currency
    {
        [JsonPropertyName("@uniquename")]
        public Uniquename Uniquename { get; set; }

        [JsonPropertyName("@amount")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Amount { get; set; }
    }
}
