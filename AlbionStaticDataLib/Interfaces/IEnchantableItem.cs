using AlbionStaticDataLib.Json.Items.Models;

namespace AlbionStaticDataLib.Interfaces
{
    internal interface IEnchantableItem
    {
        public Enchantments? Enchantments { get; set; }
    }
}
