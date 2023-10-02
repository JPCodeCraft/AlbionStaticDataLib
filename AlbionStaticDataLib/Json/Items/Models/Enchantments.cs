using AlbionStaticDataLib.Json.Shared.Converters;

namespace AlbionStaticDataLib.Json.Items.Models
{
    public class Enchantments
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("enchantment")]
        [JsonConverter(typeof(SingleOrArrayConverter<Enchantment>))]
        public List<Enchantment>? EnchantmentList { get; set; }
    }
}
