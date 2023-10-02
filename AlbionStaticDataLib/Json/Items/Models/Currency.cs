using AlbionStaticDataLib.Json.Items.Enums;
using AlbionStaticDataLib.Json.Shared.Converters;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Json.Items.Models

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
