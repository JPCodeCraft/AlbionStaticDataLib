using AlbionStaticDataLib.Input.Resources.Converters;
using AlbionStaticDataLib.Input.Resources.Models;
using System.Text.Json;

namespace AlbionStaticDataLib.Tests.Input.Resources.Models
{
    [TestClass]
    public class ResourcesTests
    {
        [TestMethod]
        public async Task TestDeserialization()
        {
            using HttpClient client = new HttpClient();
            string json = await client.GetStringAsync(JsonUrl.Resources);

            ResourcesRoot resourcesRoot = JsonSerializer.Deserialize<ResourcesRoot>(json, ResourcesConverter.Settings);

            // Now you can perform various assertions to ensure the deserialization worked as expected
            Assert.IsNotNull(resourcesRoot);
            Assert.IsNotNull(resourcesRoot.AoResources);
            Assert.IsNotNull(resourcesRoot.AoResources.Resources);
            Assert.IsNotNull(resourcesRoot.AoResources.Harvestables);
            Assert.AreNotEqual(0, resourcesRoot.AoResources.Resources.Resource.Count);
            Assert.AreNotEqual(0, resourcesRoot.AoResources.Harvestables.Harvestable.Count);
        }
    }
}
