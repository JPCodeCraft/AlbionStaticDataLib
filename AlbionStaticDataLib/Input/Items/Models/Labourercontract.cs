using AlbionStaticDataLib.Input.Items.Enums;
using AlbionStaticDataLib.Input.Shared.Converters;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Labourercontract
    {
        [JsonPropertyName("@uniquename")]
        public string Uniquename { get; set; }

        [JsonPropertyName("@tier")]
        [JsonConverter(typeof(StringToIntConverter))]
        public int Tier { get; set; }

        [JsonPropertyName("@shopcategory")]
        public ShopCategoryName Shopcategory { get; set; }

        [JsonPropertyName("@shopsubcategory1")]
        public ShopsubcategoryName Shopsubcategory1 { get; set; }

        [JsonPropertyName("@unlockedtocraft")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool Unlockedtocraft { get; set; }

        [JsonPropertyName("@weight")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Weight { get; set; }
    }
}
