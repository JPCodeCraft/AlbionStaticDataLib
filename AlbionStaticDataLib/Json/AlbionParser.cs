using AlbionStaticDataLib.Json.Items.Models;
using AlbionStaticDataLib.Json.Localization.Models;
using AlbionStaticDataLib.Json.Resources.Models;
using System.Text;

namespace AlbionStaticDataLib.Json
{
    public class AlbionParser
    {
        private readonly HttpClient _client;

        public AlbionParser(HttpClient client)
        {
            _client = client;
        }

        public async Task<LocalizationItem[]> GetLocalizationItems(string url)
        {
            string json = await _client.GetStringAsync(url);
            using MemoryStream jsonStream = new MemoryStream(Encoding.UTF8.GetBytes(json));
            var items = await JsonSerializer.DeserializeAsync<LocalizationItem[]>(jsonStream);
            return items;
        }
        public async Task<ResourcesRoot> GetResources(string url)
        {
            string json = await _client.GetStringAsync(url);
            using MemoryStream jsonStream = new MemoryStream(Encoding.UTF8.GetBytes(json));
            var items = await JsonSerializer.DeserializeAsync<ResourcesRoot>(jsonStream);
            return items;
        }
        public async Task<ItemsRoot> GetItems(string url)
        {
            string json = await _client.GetStringAsync(url);
            using MemoryStream jsonStream = new MemoryStream(Encoding.UTF8.GetBytes(json));
            var items = await JsonSerializer.DeserializeAsync<ItemsRoot>(jsonStream);
            return items;
        }
    }
}
