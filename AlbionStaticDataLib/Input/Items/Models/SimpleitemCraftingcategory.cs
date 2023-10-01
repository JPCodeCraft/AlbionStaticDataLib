using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    [JsonConverter(typeof(JsonStringEnumConverter<SimpleitemCraftingcategory>))]
    public enum SimpleitemCraftingcategory { Fiber, Food, Hide, Ore, Rock, Wood };
}
