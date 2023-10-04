using AlbionStaticDataLib.Crafting;
using AlbionStaticDataLib.Interfaces;
using Microsoft.Extensions.Hosting;

namespace AlbionStaticDataLib.ConsoleApp
{
    internal class CraftWorker : BackgroundService
    {
        ICraftingProvider _craftingProvider;
        public CraftWorker(ICraftingProvider craftingProvider)
        {
            _craftingProvider = craftingProvider;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await _craftingProvider
                .WithResourcesUrl("https://raw.githubusercontent.com/ao-data/ao-bin-dumps/master/resources.json")
                .WithItemsUrl("https://raw.githubusercontent.com/ao-data/ao-bin-dumps/master/items.json")
                .WithLocalizationUrl("https://raw.githubusercontent.com/ao-data/ao-bin-dumps/master/formatted/items.json")
                .LoadData();

            var items = _craftingProvider.FilterByType<IEnchantableItem>();

            int i = 0;
            foreach (var item in items)
            {
                if (item.Enchantments?.EnchantmentList?.Count > 0)
                {
                    Console.WriteLine(item.Uniquename);
                    foreach (var enchantment in item.Enchantments.EnchantmentList)
                    {
                        Console.WriteLine($" => Enchantment level: {enchantment.Enchantmentlevel}");
                    }
                    i++;
                }
                if (i > 100)
                {
                    break;
                }
            }

        }
    }
}
