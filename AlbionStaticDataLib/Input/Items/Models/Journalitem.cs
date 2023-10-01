using AlbionStaticDataLib.Input.Items.Enums;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Journalitem
    {
        [JsonPropertyName("@salvageable")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool Salvageable { get; set; }

        [JsonPropertyName("@uniquename")]
        public string Uniquename { get; set; }

        [JsonPropertyName("@tier")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Tier { get; set; }

        [JsonPropertyName("@maxfame")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Maxfame { get; set; }

        [JsonPropertyName("@baselootamount")]
        public string Baselootamount { get; set; }

        [JsonPropertyName("@shopcategory")]
        public ShopCategoryName Shopcategory { get; set; }

        [JsonPropertyName("@shopsubcategory1")]
        public ShopsubcategoryName Shopsubcategory1 { get; set; }

        [JsonPropertyName("@weight")]
        public string Weight { get; set; }

        [JsonPropertyName("@unlockedtocraft")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool Unlockedtocraft { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@fasttravelfactor")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long? Fasttravelfactor { get; set; }

        [JsonPropertyName("craftingrequirements")]
        public JournalitemCraftingrequirements Craftingrequirements { get; set; }

        [JsonPropertyName("famefillingmissions")]
        public Famefillingmissions Famefillingmissions { get; set; }

        [JsonPropertyName("lootlist")]
        public Lootlist Lootlist { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("@uisprite")]
        public string Uisprite { get; set; }
    }
}
