﻿using AlbionStaticDataLib.Json.Items.Enums;
using AlbionStaticDataLib.Json.Shared.Converters;

namespace AlbionStaticDataLib.Json.Items.Models

{
    public class Farmableitem : ICraftableItem
    {
        [JsonPropertyName("@uniquename")]
        public string Uniquename { get; set; }

        [JsonPropertyName("@tier")]
        [JsonConverter(typeof(StringToIntConverter))]
        public int Tier { get; set; }

        [JsonPropertyName("@placefame")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Placefame { get; set; }

        [JsonPropertyName("@pickupable")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool Pickupable { get; set; }

        [JsonPropertyName("@destroyable")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool Destroyable { get; set; }

        [JsonPropertyName("@unlockedtoplace")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool Unlockedtoplace { get; set; }

        [JsonPropertyName("@maxstacksize")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Maxstacksize { get; set; }

        [JsonPropertyName("@shopcategory")]
        public ShopCategoryName Shopcategory { get; set; }

        [JsonPropertyName("@shopsubcategory1")]
        public ShopsubcategoryName Shopsubcategory { get; set; }

        [JsonPropertyName("@kind")]
        public FarmableItemKind Kind { get; set; }

        [JsonPropertyName("@weight")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double Weight { get; set; }

        [JsonPropertyName("@unlockedtocraft")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool? Unlockedtocraft { get; set; }

        [JsonPropertyName("@animationid")]
        public Animationid Animationid { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@activefarmfocuscost")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Activefarmfocuscost { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@activefarmmaxcycles")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Activefarmmaxcycles { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@activefarmactiondurationseconds")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Activefarmactiondurationseconds { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@activefarmcyclelengthseconds")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Activefarmcyclelengthseconds { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@activefarmbonus")]
        public string Activefarmbonus { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@itemvalue")]
        [JsonConverter(typeof(StringToDoubleConverter))]
        public double? Itemvalue { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("craftingrequirements")]
        [JsonConverter(typeof(SingleOrArrayConverter<Craftingrequirements>))]
        public List<Craftingrequirements>? Craftingrequirements { get; set; }

        [JsonPropertyName("AudioInfo")]
        public AudioInfo AudioInfo { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("harvest")]
        public Harvest Harvest { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@prefabname")]
        public string Prefabname { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@prefabscale")]
        public string Prefabscale { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@resourcevalue")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long? Resourcevalue { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("grownitem")]
        public Grownitem Grownitem { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("consumption")]
        public Consumption Consumption { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@tile")]
        public string Tile { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@uisprite")]
        public string Uisprite { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@showinmarketplace")]
        [JsonConverter(typeof(StringToBoolConverter))]
        public bool? Showinmarketplace { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("products")]
        public Products Products { get; set; }
    }
}
