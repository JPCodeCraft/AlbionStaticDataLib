using AlbionStaticDataLib.Json.Items.Enums;

namespace AlbionStaticDataLib.Interfaces
{
    public interface IBaseItem
    {
        string Uniquename { get; set; }
        int Tier { get; set; }
        double Weight { get; set; }
        bool? Unlockedtocraft { get; set; }
        ShopCategoryName Shopcategory { get; set; }
        ShopsubcategoryName Shopsubcategory { get; set; }

    }
}
