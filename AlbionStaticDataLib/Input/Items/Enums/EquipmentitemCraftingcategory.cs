using AlbionStaticDataLib.Input.Items.Converters;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    [JsonConverter(typeof(EquipmentitemCraftingcategoryConverter))]
    public enum EquipmentitemCraftingcategory
    {
        Bag,
        Cape,
        ClothArmor, ClothHelmet, ClothShoes, Gatherergear, LeatherArmor,
        LeatherHelmet, LeatherShoes, Offhand, PlateArmor, PlateHelmet, PlateShoes
    };
}
