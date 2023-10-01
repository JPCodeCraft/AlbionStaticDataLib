using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class EnchantmentsEnchantmentClass
    {
        [JsonPropertyName("@enchantmentlevel")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Enchantmentlevel { get; set; }

        [JsonPropertyName("@itempower")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Itempower { get; set; }

        [JsonPropertyName("@durability")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Durability { get; set; }

        [JsonPropertyName("craftingrequirements")]
        public EquipmentitemCraftingrequirements Craftingrequirements { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("upgraderequirements")]
        public Upgraderequirements Upgraderequirements { get; set; }
    }
}
