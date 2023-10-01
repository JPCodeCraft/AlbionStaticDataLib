using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Items.Converters;

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
        [JsonConverter(typeof(StringToLongConverter))]
        public long Tier { get; set; }

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
        public Shop Shopcategory { get; set; }

        [JsonPropertyName("@shopsubcategory1")]
        public Shop Shopsubcategory1 { get; set; }

        [JsonPropertyName("@uicraftsoundstart")]
        public EquipmentitemUicraftsoundstart Uicraftsoundstart { get; set; }

        [JsonPropertyName("@uicraftsoundfinish")]
        public EquipmentitemUicraftsoundfinish Uicraftsoundfinish { get; set; }

        [JsonPropertyName("craftingrequirements")]
        public HideoutitemCraftingrequirements Craftingrequirements { get; set; }
    }
}
