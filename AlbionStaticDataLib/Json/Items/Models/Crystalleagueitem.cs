using AlbionStaticDataLib.Json.Items.Enums;
using AlbionStaticDataLib.Json.Shared.Converters;
using AlbionStaticDataLib.Json.Shared.Enums;

namespace AlbionStaticDataLib.Json.Items.Models

{
    public class Crystalleagueitem : ICraftableItem
    {
        [JsonPropertyName("@uniquename")]
        public string Uniquename { get; set; }

        [JsonPropertyName("@uisprite")]
        public string Uisprite { get; set; }

        [JsonPropertyName("@shopcategory")]
        public ShopCategoryName Shopcategory { get; set; }

        [JsonPropertyName("@shopsubcategory1")]
        public ShopsubcategoryName Shopsubcategory { get; set; }

        [JsonPropertyName("@tier")]
        [JsonConverter(typeof(StringToIntConverter))]
        public int Tier { get; set; }

        [JsonPropertyName("@enchantmentlevel")]
        [JsonConverter(typeof(StringToIntConverter))]
        public int Enchantmentlevel { get; set; }

        [JsonPropertyName("@resourcetype")]
        public ResourceType Resourcetype { get; set; }

        [JsonPropertyName("@weight")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Weight { get; set; }

        [JsonPropertyName("@maxstacksize")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Maxstacksize { get; set; }

        [JsonPropertyName("@namelocatag")]
        public string Namelocatag { get; set; }

        [JsonPropertyName("@descriptionlocatag")]
        public string Descriptionlocatag { get; set; }

        [JsonPropertyName("@descvariable0")]
        public string Descvariable0 { get; set; }

        [JsonPropertyName("@salvageable")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool Salvageable { get; set; }

        [JsonPropertyName("@itemvalue")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Itemvalue { get; set; }

        [JsonPropertyName("@tradable")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool Tradable { get; set; }

        [JsonPropertyName("@unlockedtocraft")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool? Unlockedtocraft { get; set; }

        [JsonPropertyName("@canbestoredinbattlevault")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool Canbestoredinbattlevault { get; set; }

        [JsonPropertyName("craftingrequirements")]
        [JsonConverter(typeof(SingleOrArrayConverter<Craftingrequirements>))]
        public List<Craftingrequirements>? Craftingrequirements { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@uispriteoverlay1")]
        public string? Uispriteoverlay1 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@showinmarketplace")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool? Showinmarketplace { get; set; }
    }
}
