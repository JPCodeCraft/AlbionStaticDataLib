﻿using AlbionStaticDataLib.Input.Items.Enums;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Consumableitem
    {
        [JsonPropertyName("@uniquename")]
        public string Uniquename { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@itemvalue")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Itemvalue { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@fishingfame")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Fishingfame { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@fishingminigamesetting")]
        public string Fishingminigamesetting { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@descriptionlocatag")]
        public string Descriptionlocatag { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@uisprite")]
        public string Uisprite { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@nutrition")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Nutrition { get; set; }

        [JsonPropertyName("@abilitypower")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Abilitypower { get; set; }

        [JsonPropertyName("@slottype")]
        public SlottypeEnum Slottype { get; set; }

        [JsonPropertyName("@consumespell")]
        public string Consumespell { get; set; }

        [JsonPropertyName("@shopcategory")]
        public ShopCategoryName Shopcategory { get; set; }

        [JsonPropertyName("@shopsubcategory1")]
        public ShopsubcategoryName Shopsubcategory1 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@resourcetype")]
        public ConsumableitemResourcetype? Resourcetype { get; set; }

        [JsonPropertyName("@tier")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Tier { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@weight")]
        public string Weight { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@dummyitempower")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Dummyitempower { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@maxstacksize")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Maxstacksize { get; set; }

        [JsonPropertyName("@unlockedtocraft")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool Unlockedtocraft { get; set; }

        [JsonPropertyName("@unlockedtoequip")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool Unlockedtoequip { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@uicraftsoundstart")]
        public ConsumableitemUicraftsoundstart? Uicraftsoundstart { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@uicraftsoundfinish")]
        public ConsumableitemUicraftsoundfinish? Uicraftsoundfinish { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@craftingcategory")]
        public SlottypeEnum? Craftingcategory { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("craftingrequirements")]
        public ConsumableitemCraftingrequirements Craftingrequirements { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("enchantments")]
        public ConsumableitemEnchantments Enchantments { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@famevalue")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Famevalue { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@uispriteoverlay1")]
        public Uispriteoverlay? Uispriteoverlay1 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@tradable")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool? Tradable { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@foodcategory")]
        public Foodcategory? Foodcategory { get; set; }
    }
}