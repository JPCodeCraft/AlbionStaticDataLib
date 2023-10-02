using AlbionStaticDataLib.Input.Shared.Converters;

namespace AlbionStaticDataLib.Input.Items.Models
{
    public class Enchantments
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("enchantment")]
        [JsonConverter(typeof(SingleOrArrayConverter<Enchantment>))]
        public List<Enchantment>? EnchantmentList { get; set; }
    }
}
