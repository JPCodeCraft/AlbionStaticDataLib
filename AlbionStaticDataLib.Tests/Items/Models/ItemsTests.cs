﻿
using AlbionStaticDataLib.Json;
using AlbionStaticDataLib.Json.Items.Models;
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

            //string json = await client.GetStringAsync(JsonUrl.Items);
            //var jsonDocument = JsonDocument.Parse(json);
            //List<string> a = new();
            //ExtractPropValues(jsonDocument.RootElement, a, "@mountcategory");
            //HashSet<string> b = new(a);
            //string result = string.Join(", ", b);

            try
            {
                ItemsRoot itemsRoot = await new AlbionParser(client).GetItems(JsonUrl.Items);
                Assert.IsNotNull(itemsRoot);
                Assert.IsNotNull(itemsRoot.Items);
                Assert.AreNotEqual(0, itemsRoot.Items.Weapon.Count);
            }
            catch (JsonException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw;
            }

        }

        //static void ExtractPropValues(JsonElement element, List<string> a, string propName)
        //{
        //    switch (element.ValueKind)
        //    {
        //        case JsonValueKind.Object:
        //            foreach (JsonProperty property in element.EnumerateObject())
        //            {
        //                if (property.Name == propName)
        //                {
        //                    a.Add(property.Value.GetString());
        //                }
        //                else
        //                {
        //                    ExtractPropValues(property.Value, a, propName);
        //                }
        //            }
        //            break;

        //        case JsonValueKind.Array:
        //            foreach (JsonElement arrayElement in element.EnumerateArray())
        //            {
        //                ExtractPropValues(arrayElement, a, propName);
        //            }
        //            break;
        //    }
        //}
    }
}
