using AlbionStaticDataLib.Json.Items.Models;

namespace AlbionStaticDataLib.Interfaces
{
    public interface IEnchantableItem : ICraftableItem
    {
        public Enchantments? Enchantments { get; set; }
    }
}
