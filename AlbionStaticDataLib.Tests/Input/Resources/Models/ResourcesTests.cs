using AlbionStaticDataLib.Json;
using AlbionStaticDataLib.Json.Resources.Models;

namespace AlbionStaticDataLib.Tests.Input.Resources.Models
{
    [TestClass]
    public class ResourcesTests
    {
        [TestMethod]
        public async Task TestDeserialization()
        {
            using HttpClient client = new HttpClient();

            ResourcesRoot resourcesRoot = await new AlbionParser(client).GetResources(JsonUrl.Resources);

            Assert.IsNotNull(resourcesRoot);
            Assert.IsNotNull(resourcesRoot.AoResources);
            Assert.IsNotNull(resourcesRoot.AoResources.Resources);
            Assert.IsNotNull(resourcesRoot.AoResources.Harvestables);
            Assert.AreNotEqual(0, resourcesRoot.AoResources.Resources.Resource.Count);
            Assert.AreNotEqual(0, resourcesRoot.AoResources.Harvestables.Harvestable.Count);
        }
    }
}
