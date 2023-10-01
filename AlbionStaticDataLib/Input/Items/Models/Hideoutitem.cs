using AlbionStaticDataLib.Input.Items.Enums;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Hideoutitem
    {
        [JsonPropertyName("@uniquename")]
        public string Uniquename { get; set; }

        [JsonPropertyName("@itemvalue")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Itemvalue { get; set; }

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
        [JsonConverter(typeof(StringToLongConverter))]
        public long Weight { get; set; }

        [JsonPropertyName("@unlockedtocraft")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool Unlockedtocraft { get; set; }

        [JsonPropertyName("@shopcategory")]
        public ShopCategoryName Shopcategory { get; set; }

        [JsonPropertyName("@shopsubcategory1")]
        public ShopsubcategoryName Shopsubcategory1 { get; set; }

        [JsonPropertyName("@uicraftsoundstart")]
        public string Uicraftsoundstart { get; set; }

        [JsonPropertyName("@uicraftsoundfinish")]
        public string Uicraftsoundfinish { get; set; }

        [JsonPropertyName("craftingrequirements")]
        public HideoutitemCraftingrequirements Craftingrequirements { get; set; }
    }
}
