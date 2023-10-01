﻿using AlbionStaticDataLib.Input.Items.Enums;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Crystalleagueitem
    {
        [JsonPropertyName("@uniquename")]
        public string Uniquename { get; set; }

        [JsonPropertyName("@uisprite")]
        public string Uisprite { get; set; }

        [JsonPropertyName("@shopcategory")]
        public ShopCategoryName Shopcategory { get; set; }

        [JsonPropertyName("@shopsubcategory1")]
        public ShopsubcategoryName Shopsubcategory1 { get; set; }

        [JsonPropertyName("@tier")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Tier { get; set; }

        [JsonPropertyName("@enchantmentlevel")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Enchantmentlevel { get; set; }

        [JsonPropertyName("@resourcetype")]
        public CrystalleagueitemResourcetype Resourcetype { get; set; }

        [JsonPropertyName("@weight")]
        public string Weight { get; set; }

        [JsonPropertyName("@maxstacksize")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Maxstacksize { get; set; }

        [JsonPropertyName("@namelocatag")]
        public Namelocatag Namelocatag { get; set; }

        [JsonPropertyName("@descriptionlocatag")]
        public CrystalleagueitemDescriptionlocatag Descriptionlocatag { get; set; }

        [JsonPropertyName("@descvariable0")]
        public string Descvariable0 { get; set; }

        [JsonPropertyName("@salvageable")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool Salvageable { get; set; }

        [JsonPropertyName("@itemvalue")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Itemvalue { get; set; }

        [JsonPropertyName("@tradable")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool Tradable { get; set; }

        [JsonPropertyName("@unlockedtocraft")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool Unlockedtocraft { get; set; }

        [JsonPropertyName("@canbestoredinbattlevault")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool Canbestoredinbattlevault { get; set; }

        [JsonPropertyName("craftingrequirements")]
        public CrystalleagueitemCraftingrequirements Craftingrequirements { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@uispriteoverlay1")]
        public Uispriteoverlay? Uispriteoverlay1 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@showinmarketplace")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Showinmarketplace { get; set; }
    }
}