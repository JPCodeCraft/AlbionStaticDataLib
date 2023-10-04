using AlbionStaticDataLib.Json;
using AlbionStaticDataLib.Json.Items.Models;
using AlbionStaticDataLib.Json.Localization.Models;
using AlbionStaticDataLib.Json.Resources.Models;

namespace AlbionStaticDataLib.Crafting
{
    public class CraftingProvider : ICraftingProvider
    {
        private readonly IAlbionParser _albionParser;

        private ItemsRoot Items { get; set; }
        private LocalizationItem[] LocalizationItems { get; set; }
        private ResourcesRoot Resources { get; set; }
        private string ItemsUrl { get; set; }
        private string LocalizationUrl { get; set; }
        private string ResourcesUrl { get; set; }
        private List<object> ItemsList { get; set; } = new List<object>();

        public CraftingProvider(IAlbionParser albionParser)
        {
            _albionParser = albionParser;
        }
        private async Task LoadItems(string url)
        {
            Items = await _albionParser.GetItems(url);
        }
        private async Task LoadLocalizationItems(string url)
        {
            LocalizationItems = await _albionParser.GetLocalizationItems(url);
        }
        private async Task LoadResources(string url)
        {
            Resources = await _albionParser.GetResources(url);
        }
        public CraftingProvider WithItemsUrl(string url)
        {
            ItemsUrl = url;
            return this;
        }
        public CraftingProvider WithLocalizationUrl(string url)
        {
            LocalizationUrl = url;
            return this;
        }
        public CraftingProvider WithResourcesUrl(string url)
        {
            ResourcesUrl = url;
            return this;
        }
        public async Task LoadData()
        {
            ValidateUrls();
            var tasks = new List<Task> { LoadItems(ItemsUrl), LoadLocalizationItems(LocalizationUrl), LoadResources(ResourcesUrl) };
            await Task.WhenAll(tasks);
            ItemsList.Add(Items.Items.Hideoutitem);
            ItemsList.Add(Items.Items.Killtrophy);
            ItemsList.AddRange(Items.Items.Farmableitem);
            ItemsList.AddRange(Items.Items.Simpleitem);
            ItemsList.AddRange(Items.Items.Consumableitem);
            ItemsList.AddRange(Items.Items.Consumablefrominventoryitem);
            ItemsList.AddRange(Items.Items.Equipmentitem);
            ItemsList.AddRange(Items.Items.Weapon);
            ItemsList.AddRange(Items.Items.Mount);
            ItemsList.AddRange(Items.Items.Furnitureitem);
            ItemsList.AddRange(Items.Items.Mountskin);
            ItemsList.AddRange(Items.Items.Journalitem);
            ItemsList.AddRange(Items.Items.Labourercontract);
            ItemsList.AddRange(Items.Items.Crystalleagueitem);
        }

        public List<T> FilterByType<T>() where T : IItemType
        {
            return ItemsList.OfType<T>().ToList();
        }

        private void ValidateUrls()
        {
            if (string.IsNullOrEmpty(ItemsUrl) ||
                string.IsNullOrEmpty(LocalizationUrl) ||
                string.IsNullOrEmpty(ResourcesUrl))
            {
                throw new InvalidOperationException("All URLs must be set before loading data.");
            }
        }
    }
}
