using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Items.Converters;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class EnchantmentsEnchantmentClass
    {
        [JsonPropertyName("@enchantmentlevel")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Enchantmentlevel { get; set; }

        [JsonPropertyName("@itempower")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Itempower { get; set; }

        [JsonPropertyName("@durability")]
        [JsonConverter(typeof(StringToLongConverter))]
        public long Durability { get; set; }

        [JsonPropertyName("craftingrequirements")]
        public EquipmentitemCraftingrequirements Craftingrequirements { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("upgraderequirements")]
        public Upgraderequirements Upgraderequirements { get; set; }
    }
}
