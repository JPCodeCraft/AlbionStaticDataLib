using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class EquipmentitemEnchantments
    {
        [JsonPropertyName("enchantment")]
        public List<EnchantmentsEnchantmentClass> Enchantment { get; set; }
    }
}
