using AlbionStaticDataLib.Input.Items.Models;
using System.Text.Json;

namespace AlbionStaticDataLib.Tests.Items.Models
{
    [TestClass]
    public class ItemsTests
    {
        [TestMethod]
        public async Task TestDeserialization()
        {
            using HttpClient client = new HttpClient();
            string json = await client.GetStringAsync(JsonUrl.Items);

            ItemsRoot itemsRoot = JsonSerializer.Deserialize<ItemsRoot>(json, ItemsConverter.Settings);

            // Now you can perform various assertions to ensure the deserialization worked as expected
            Assert.IsNotNull(itemsRoot);
            Assert.IsNotNull(itemsRoot.Items);
            Assert.AreNotEqual(0, itemsRoot.Items.Weapon.Count);
        }
    }
}
