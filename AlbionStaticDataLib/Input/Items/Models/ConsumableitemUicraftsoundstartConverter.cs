using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class ConsumableitemUicraftsoundstartConverter : JsonConverter<ConsumableitemUicraftsoundstart>
    {
        public override bool CanConvert(Type t) => t == typeof(ConsumableitemUicraftsoundstart);

        public override ConsumableitemUicraftsoundstart Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "Play_ui_action_craft_food_firm_start":
                    return ConsumableitemUicraftsoundstart.PlayUiActionCraftFoodFirmStart;
                case "Play_ui_action_craft_food_fry_start":
                    return ConsumableitemUicraftsoundstart.PlayUiActionCraftFoodFryStart;
                case "Play_ui_action_craft_potion_start":
                    return ConsumableitemUicraftsoundstart.PlayUiActionCraftPotionStart;
            }
            throw new Exception("Cannot unmarshal type ConsumableitemUicraftsoundstart");
        }

        public override void Write(Utf8JsonWriter writer, ConsumableitemUicraftsoundstart value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case ConsumableitemUicraftsoundstart.PlayUiActionCraftFoodFirmStart:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_food_firm_start", options);
                    return;
                case ConsumableitemUicraftsoundstart.PlayUiActionCraftFoodFryStart:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_food_fry_start", options);
                    return;
                case ConsumableitemUicraftsoundstart.PlayUiActionCraftPotionStart:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_potion_start", options);
                    return;
            }
            throw new Exception("Cannot marshal type ConsumableitemUicraftsoundstart");
        }

        public static readonly ConsumableitemUicraftsoundstartConverter Singleton = new ConsumableitemUicraftsoundstartConverter();
    }
}
