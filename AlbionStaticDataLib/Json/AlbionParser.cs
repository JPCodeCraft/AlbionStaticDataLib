﻿using AlbionStaticDataLib.Json.Items.Models;
using AlbionStaticDataLib.Json.Localization.Models;
using AlbionStaticDataLib.Json.Resources.Models;
using System.Text;

namespace AlbionStaticDataLib.Json
{
    /// <summary>
    /// Implements the IAlbionParser interface to parse data from Albion's JSON resources.
    /// </summary>
    public class AlbionParser : IAlbionParser
    {
        private readonly HttpClient _client;

        /// <summary>
        /// Initializes a new instance of the AlbionParser class.
        /// </summary>
        /// <param name="client">The HttpClient used to send HTTP requests and receive HTTP responses from a resource identified by the specified URL.</param>

        public AlbionParser(HttpClient client)
        {
            _client = client;
        }

        /// <inheritdoc/>
        public async Task<LocalizationItem[]> GetLocalizationItems(string url)
        {
            string json = await _client.GetStringAsync(url);
            using MemoryStream jsonStream = new MemoryStream(Encoding.UTF8.GetBytes(json));
            var items = await JsonSerializer.DeserializeAsync<LocalizationItem[]>(jsonStream);
            return items;
        }

        /// <inheritdoc/>
        public async Task<ResourcesRoot> GetResources(string url)
        {
            string json = await _client.GetStringAsync(url);
            using MemoryStream jsonStream = new MemoryStream(Encoding.UTF8.GetBytes(json));
            var items = await JsonSerializer.DeserializeAsync<ResourcesRoot>(jsonStream);
            return items;
        }

        /// <inheritdoc/>
        public async Task<ItemsRoot> GetItems(string url)
        {
            string json = await _client.GetStringAsync(url);
            using MemoryStream jsonStream = new MemoryStream(Encoding.UTF8.GetBytes(json));
            var items = await JsonSerializer.DeserializeAsync<ItemsRoot>(jsonStream);
            return items;
        }
    }
}
