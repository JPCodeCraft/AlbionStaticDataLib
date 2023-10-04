using AlbionStaticDataLib.Crafting;
using AlbionStaticDataLib.Json;
using Microsoft.Extensions.DependencyInjection;

namespace AlbionStaticDataLib
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAlbionServices(
            this IServiceCollection services,
            HttpClient httpClient)
        {
            services.AddSingleton<IAlbionParser>(serviceProvider => new AlbionParser(httpClient));
            services.AddSingleton<ICraftingProvider, CraftingProvider>();
            return services;
        }
    }
}
