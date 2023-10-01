using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Items.Enums;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Killtrophy
    {
        [JsonPropertyName("@uniquename")]
        public string Uniquename { get; set; }

        [JsonPropertyName("@shopcategory")]
        public ShopCategoryName Shopcategory { get; set; }

        [JsonPropertyName("@shopsubcategory1")]
        public string Shopsubcategory1 { get; set; }

        [JsonPropertyName("@tier")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Tier { get; set; }

        [JsonPropertyName("@weight")]
        public string Weight { get; set; }

        [JsonPropertyName("@durability")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Durability { get; set; }

        [JsonPropertyName("@unlockedtocraft")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool Unlockedtocraft { get; set; }

        [JsonPropertyName("@placeableindoors")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool Placeableindoors { get; set; }

        [JsonPropertyName("@placeableoutdoors")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool Placeableoutdoors { get; set; }

        [JsonPropertyName("@placeableindungeons")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool Placeableindungeons { get; set; }

        [JsonPropertyName("@placeableinexpeditions")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool Placeableinexpeditions { get; set; }

        [JsonPropertyName("@placeableonlyonislands")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool Placeableonlyonislands { get; set; }

        [JsonPropertyName("@uisprite")]
        public string Uisprite { get; set; }

        [JsonPropertyName("@descriptionlocatag")]
        public FurnitureitemDescriptionlocatag Descriptionlocatag { get; set; }

        [JsonPropertyName("@showinmarketplace")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool Showinmarketplace { get; set; }

        [JsonPropertyName("@hidefromplayeroncontext")]
        public Hidefromplayeroncontext Hidefromplayeroncontext { get; set; }

        [JsonPropertyName("craftingrequirements")]
        public KilltrophyCraftingrequirements Craftingrequirements { get; set; }
    }
}
