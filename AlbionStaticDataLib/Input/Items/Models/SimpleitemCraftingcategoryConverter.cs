using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class SimpleitemCraftingcategoryConverter : JsonConverter<SimpleitemCraftingcategory>
    {
        public override bool CanConvert(Type t) => t == typeof(SimpleitemCraftingcategory);

        public override SimpleitemCraftingcategory Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "fiber":
                    return SimpleitemCraftingcategory.Fiber;
                case "food":
                    return SimpleitemCraftingcategory.Food;
                case "hide":
                    return SimpleitemCraftingcategory.Hide;
                case "ore":
                    return SimpleitemCraftingcategory.Ore;
                case "rock":
                    return SimpleitemCraftingcategory.Rock;
                case "wood":
                    return SimpleitemCraftingcategory.Wood;
            }
            throw new Exception("Cannot unmarshal type SimpleitemCraftingcategory");
        }

        public override void Write(Utf8JsonWriter writer, SimpleitemCraftingcategory value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case SimpleitemCraftingcategory.Fiber:
                    JsonSerializer.Serialize(writer, "fiber", options);
                    return;
                case SimpleitemCraftingcategory.Food:
                    JsonSerializer.Serialize(writer, "food", options);
                    return;
                case SimpleitemCraftingcategory.Hide:
                    JsonSerializer.Serialize(writer, "hide", options);
                    return;
                case SimpleitemCraftingcategory.Ore:
                    JsonSerializer.Serialize(writer, "ore", options);
                    return;
                case SimpleitemCraftingcategory.Rock:
                    JsonSerializer.Serialize(writer, "rock", options);
                    return;
                case SimpleitemCraftingcategory.Wood:
                    JsonSerializer.Serialize(writer, "wood", options);
                    return;
            }
            throw new Exception("Cannot marshal type SimpleitemCraftingcategory");
        }

        public static readonly SimpleitemCraftingcategoryConverter Singleton = new SimpleitemCraftingcategoryConverter();
    }
}
