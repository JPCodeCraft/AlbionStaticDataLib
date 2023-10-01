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

            //var jsonDocument = JsonDocument.Parse(json);

            //List<string> a = new();

            //ExtractCraftingCategories(jsonDocument.RootElement, a);

            //HashSet<string> b = new(a);
            //string result = string.Join(", ", b);

            ItemsRoot itemsRoot = JsonSerializer.Deserialize<ItemsRoot>(json, ItemsConverter.Settings);

            Assert.IsNotNull(itemsRoot);
            Assert.IsNotNull(itemsRoot.Items);
            Assert.AreNotEqual(0, itemsRoot.Items.Weapon.Count);
        }

        //static void ExtractCraftingCategories(JsonElement element, List<string> a)
        //{
        //    switch (element.ValueKind)
        //    {
        //        case JsonValueKind.Object:
        //            foreach (JsonProperty property in element.EnumerateObject())
        //            {
        //                if (property.Name == "@craftingcategory")
        //                {
        //                    a.Add(property.Value.GetString());
        //                }
        //                else
        //                {
        //                    ExtractCraftingCategories(property.Value, a);
        //                }
        //            }
        //            break;

        //        case JsonValueKind.Array:
        //            foreach (JsonElement arrayElement in element.EnumerateArray())
        //            {
        //                ExtractCraftingCategories(arrayElement, a);
        //            }
        //            break;
        //    }
        //}
    }
}
