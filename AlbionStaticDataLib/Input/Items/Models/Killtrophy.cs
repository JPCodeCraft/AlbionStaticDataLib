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
        public ShopsubcategoryName Shopsubcategory1 { get; set; }

        [JsonPropertyName("@tier")]
        [JsonConverter(typeof(StringToIntConverter))]
        public int Tier { get; set; }

        [JsonPropertyName("@weight")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Weight { get; set; }

        [JsonPropertyName("@durability")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Durability { get; set; }

        [JsonPropertyName("@unlockedtocraft")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool Unlockedtocraft { get; set; }

        [JsonPropertyName("@placeableindoors")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool Placeableindoors { get; set; }

        [JsonPropertyName("@placeableoutdoors")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool Placeableoutdoors { get; set; }

        [JsonPropertyName("@placeableindungeons")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool Placeableindungeons { get; set; }

        [JsonPropertyName("@placeableinexpeditions")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool Placeableinexpeditions { get; set; }

        [JsonPropertyName("@placeableonlyonislands")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool Placeableonlyonislands { get; set; }

        [JsonPropertyName("@uisprite")]
        public string Uisprite { get; set; }

        [JsonPropertyName("@descriptionlocatag")]
        public string Descriptionlocatag { get; set; }

        [JsonPropertyName("@showinmarketplace")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool Showinmarketplace { get; set; }

        [JsonPropertyName("@hidefromplayeroncontext")]
        public string Hidefromplayeroncontext { get; set; }

        [JsonPropertyName("craftingrequirements")]
        [JsonConverter(typeof(SingleOrArrayConverter<Craftingrequirements>))]
        public List<Craftingrequirements>? Craftingrequirements { get; set; }
    }
}
