using AlbionStaticDataLib.Json.Items.Enums;
using AlbionStaticDataLib.Json.Shared.Converters;

namespace AlbionStaticDataLib.Json.Items.Models

{
    public class Hideoutitem : INamedItem, IBaseItem, ICraftableItem
    {
        [JsonPropertyName("@uniquename")]
        public string Uniquename { get; set; }

        [JsonPropertyName("@itemvalue")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Itemvalue { get; set; }

        [JsonPropertyName("@tier")]
        [JsonConverter(typeof(StringToIntConverter))]
        public int Tier { get; set; }

        [JsonPropertyName("@mindistance")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Mindistance { get; set; }

        [JsonPropertyName("@mindistanceintunnel")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Mindistanceintunnel { get; set; }

        [JsonPropertyName("@placementduration")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Placementduration { get; set; }

        [JsonPropertyName("@primetimedurationminutes")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Primetimedurationminutes { get; set; }

        [JsonPropertyName("@maxstacksize")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Maxstacksize { get; set; }

        [JsonPropertyName("@weight")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Weight { get; set; }

        [JsonPropertyName("@unlockedtocraft")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool? Unlockedtocraft { get; set; }

        [JsonPropertyName("@shopcategory")]
        public ShopCategoryName Shopcategory { get; set; }

        [JsonPropertyName("@shopsubcategory1")]
        public ShopsubcategoryName Shopsubcategory { get; set; }

        [JsonPropertyName("@uicraftsoundstart")]
        public string Uicraftsoundstart { get; set; }

        [JsonPropertyName("@uicraftsoundfinish")]
        public string Uicraftsoundfinish { get; set; }

        [JsonPropertyName("craftingrequirements")]
        [JsonConverter(typeof(SingleOrArrayConverter<Craftingrequirements>))]
        public List<Craftingrequirements>? Craftingrequirements { get; set; }
    }
}
