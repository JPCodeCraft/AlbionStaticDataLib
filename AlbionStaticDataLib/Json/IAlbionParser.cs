using AlbionStaticDataLib.Json.Items.Models;
using AlbionStaticDataLib.Json.Localization.Models;
using AlbionStaticDataLib.Json.Resources.Models;

namespace AlbionStaticDataLib.Json
{
    /// <summary>
    /// Provides methods to parse data from Albion's JSON resources.
    /// </summary>
    public interface IAlbionParser
    {
        /// <summary>
        /// Retrieves and parses item data from the specified JSON URL. Usually AO-DATA Repository is used.
        /// </summary>
        /// <param name="url">The URL from which to retrieve JSON data.</param>
        /// <returns>A Task representing the asynchronous operation, containing the parsed ItemsRoot object.</returns>
        Task<ItemsRoot> GetItems(string url);

        /// <summary>
        /// Retrieves and parses localization data from the specified JSON URL. Usually AO-DATA Repository is used.
        /// </summary>
        /// <param name="url">The URL from which to retrieve JSON data.</param>
        /// <returns>A Task representing the asynchronous operation, containing an array of LocalizationItem objects.</returns>
        Task<LocalizationItem[]> GetLocalizationItems(string url);

        /// <summary>
        /// Retrieves and parses resource data from the specified JSON URL. Usually AO-DATA Repository is used.
        /// </summary>
        /// <param name="url">The URL from which to retrieve resource JSON data.</param>
        /// <returns>A Task representing the asynchronous operation, containing the parsed ResourcesRoot object.</returns>
        Task<ResourcesRoot> GetResources(string url);
    }
}