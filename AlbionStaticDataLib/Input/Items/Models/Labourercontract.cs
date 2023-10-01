using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Items.Converters;
using AlbionStaticDataLib.Input.Items.Enums;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Labourercontract
    {
        [JsonPropertyName("@uniquename")]
        public string Uniquename { get; set; }

        [JsonPropertyName("@tier")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Tier { get; set; }

        [JsonPropertyName("@shopcategory")]
        public ShopCategoryName Shopcategory { get; set; }

        [JsonPropertyName("@shopsubcategory1")]
        public string Shopsubcategory1 { get; set; }

        [JsonPropertyName("@unlockedtocraft")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool Unlockedtocraft { get; set; }

        [JsonPropertyName("@weight")]
        public string Weight { get; set; }
    }
}
