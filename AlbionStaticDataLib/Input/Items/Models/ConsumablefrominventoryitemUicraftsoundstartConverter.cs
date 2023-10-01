using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class ConsumablefrominventoryitemUicraftsoundstartConverter : JsonConverter<ConsumablefrominventoryitemUicraftsoundstart>
    {
        public override bool CanConvert(Type t) => t == typeof(ConsumablefrominventoryitemUicraftsoundstart);

        public override ConsumablefrominventoryitemUicraftsoundstart Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "Play_ui_action_craft_cloth_start":
                    return ConsumablefrominventoryitemUicraftsoundstart.PlayUiActionCraftClothStart;
                case "Play_ui_action_craft_leather_start":
                    return ConsumablefrominventoryitemUicraftsoundstart.PlayUiActionCraftLeatherStart;
                case "Play_ui_action_craft_potion_start":
                    return ConsumablefrominventoryitemUicraftsoundstart.PlayUiActionCraftPotionStart;
            }
            throw new Exception("Cannot unmarshal type ConsumablefrominventoryitemUicraftsoundstart");
        }

        public override void Write(Utf8JsonWriter writer, ConsumablefrominventoryitemUicraftsoundstart value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case ConsumablefrominventoryitemUicraftsoundstart.PlayUiActionCraftClothStart:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_cloth_start", options);
                    return;
                case ConsumablefrominventoryitemUicraftsoundstart.PlayUiActionCraftLeatherStart:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_leather_start", options);
                    return;
                case ConsumablefrominventoryitemUicraftsoundstart.PlayUiActionCraftPotionStart:
                    JsonSerializer.Serialize(writer, "Play_ui_action_craft_potion_start", options);
                    return;
            }
            throw new Exception("Cannot marshal type ConsumablefrominventoryitemUicraftsoundstart");
        }

        public static readonly ConsumablefrominventoryitemUicraftsoundstartConverter Singleton = new ConsumablefrominventoryitemUicraftsoundstartConverter();
    }
}
