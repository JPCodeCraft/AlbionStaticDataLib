using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class ConsumableitemEnchantments
    {
        [JsonPropertyName("enchantment")]
        public EnchantmentUnion Enchantment { get; set; }
    }
}
