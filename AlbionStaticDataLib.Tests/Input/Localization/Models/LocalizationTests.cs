using AlbionStaticDataLib.Json;
using AlbionStaticDataLib.Json.Localization.Models;

namespace AlbionStaticDataLib.Tests.Input.Localization.Models
{
    [TestClass]
    public class LocalizationTests
    {
        [TestMethod]
        public async Task TestDeserialization()
        {
            using HttpClient client = new HttpClient();
            LocalizationItem[] items = await new AlbionParser(client).GetLocalizationItems(JsonUrl.Localization);
            Assert.IsNotNull(items);
            Assert.IsTrue(items.Length > 0);
        }
    }
}
