using AlbionStaticDataLib.Input.Items.Enums;
using AlbionStaticDataLib.Input.Shared.Converters;
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
