
namespace AlbionStaticDataLib.Crafting
{
    public interface ICraftingProvider
    {
        List<T> FilterByType<T>() where T : IItemType;
        Task LoadData();
        CraftingProvider WithItemsUrl(string url);
        CraftingProvider WithLocalizationUrl(string url);
        CraftingProvider WithResourcesUrl(string url);
    }
}