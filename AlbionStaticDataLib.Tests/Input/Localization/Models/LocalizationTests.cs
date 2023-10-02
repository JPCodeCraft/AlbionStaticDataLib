using AlbionStaticDataLib.Input.Localization.Models;
using System.Text.Json;

namespace AlbionStaticDataLib.Tests.Input.Localization.Models
{
    [TestClass]
    public class LocalizationTests
    {
        [TestMethod]
        public async Task TestDeserialization()
        {
            using HttpClient client = new HttpClient();
            string json = await client.GetStringAsync(JsonUrl.Localization);
            LocalizationItem[] items = JsonSerializer.Deserialize<LocalizationItem[]>(json);
            Assert.IsNotNull(items);
            Assert.IsTrue(items.Length > 0);
        }
    }
}
