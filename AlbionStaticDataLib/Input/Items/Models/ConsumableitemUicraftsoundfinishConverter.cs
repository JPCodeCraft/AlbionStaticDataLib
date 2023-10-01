using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class ConsumableitemUicraftsoundfinishConverter : JsonConverter<ConsumableitemUicraftsoundfinish>
    {
        public override bool CanConvert(Type t) => t == typeof(ConsumableitemUicraftsoundfinish);

        public override ConsumableitemUicraftsoundfinish Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "Play_ui_action_craft_food_finish":
                    return ConsumableitemUicraftsoundfinish.PlayUiActionCraftFoodFinish;
                case "Play_ui_action_craft_potion_finish":
                    return ConsumableitemUicraftsoundfinish.PlayUiActionCraftPotionFinish;
            }
            throw new Exception("Cannot unmarshal type ConsumableitemUicraftsoundfinish");
        }

        public override void Write(Utf8JsonWriter writer, ConsumableitemUicraftsoundfinish value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case ConsumableitemUicraftsoundfinish.PlayUiActionCraftFoodFinish:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_food_finish", options);
                    return;
                case ConsumableitemUicraftsoundfinish.PlayUiActionCraftPotionFinish:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_potion_finish", options);
                    return;
            }
            throw new Exception("Cannot marshal type ConsumableitemUicraftsoundfinish");
        }

        public static readonly ConsumableitemUicraftsoundfinishConverter Singleton = new ConsumableitemUicraftsoundfinishConverter();
    }
}
