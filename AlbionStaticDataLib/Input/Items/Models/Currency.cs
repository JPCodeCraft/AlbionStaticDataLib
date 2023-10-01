using AlbionStaticDataLib.Input.Items.Converters;
using AlbionStaticDataLib.Input.Items.Enums;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Currency
    {
        [JsonPropertyName("@uniquename")]
        public CurrencyName Uniquename { get; set; }

        [JsonPropertyName("@amount")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Amount { get; set; }
    }
}
