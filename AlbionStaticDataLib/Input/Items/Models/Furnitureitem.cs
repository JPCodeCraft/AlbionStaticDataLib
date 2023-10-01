using AlbionStaticDataLib.Input.Items.Enums;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Furnitureitem
    {
        [JsonPropertyName("@uniquename")]
        public string Uniquename { get; set; }

        [JsonPropertyName("@shopcategory")]
        public ShopCategoryName Shopcategory { get; set; }

        [JsonPropertyName("@shopsubcategory1")]
        public ShopsubcategoryName Shopsubcategory1 { get; set; }

        [JsonPropertyName("@tier")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Tier { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@durability")]
        public string Durability { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@durabilitylossperdayfactor")]
        public string Durabilitylossperdayfactor { get; set; }

        [JsonPropertyName("@weight")]
        public string Weight { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@unlockedtocraft")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Unlockedtocraft { get; set; }

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

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@accessrightspreset")]
        public string Accessrightspreset { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@uicraftsoundstart")]
        public string? Uicraftsoundstart { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@uicraftsoundfinish")]
        public string? Uicraftsoundfinish { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("craftingrequirements")]
        public FurnitureitemCraftingrequirements? Craftingrequirements { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("AudioInfo")]
        public AudioInfo AudioInfo { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("repairkit")]
        public Repairkit Repairkit { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@customizewithguildlogo")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Customizewithguildlogo { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@uisprite")]
        public string Uisprite { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@enchantmentlevel")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Enchantmentlevel { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@tile")]
        public string Tile { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@itemvalue")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Itemvalue { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("container")]
        public Container Container { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@showinmarketplace")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Showinmarketplace { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@residencyslots")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Residencyslots { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@labourerfurnituretype")]
        public Labourerfurnituretype? Labourerfurnituretype { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@labourersaffected")]
        public Labourersaffected? Labourersaffected { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@labourerhappiness")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Labourerhappiness { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@labourersperfurnitureitem")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Labourersperfurnitureitem { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@placeableonlyonislands")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Placeableonlyonislands { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@descriptionlocatag")]
        public string? Descriptionlocatag { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@salvageable")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Salvageable { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@hidefromplayeroncontext")]
        public string? Hidefromplayeroncontext { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@namelocatag")]
        public string Namelocatag { get; set; }

        [JsonPropertyName("cheatprovider")]
        public object Cheatprovider { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@maxstacksize")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Maxstacksize { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@tradable")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Tradable { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@durabilitylossperusefactor")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Durabilitylossperusefactor { get; set; }
    }
}
