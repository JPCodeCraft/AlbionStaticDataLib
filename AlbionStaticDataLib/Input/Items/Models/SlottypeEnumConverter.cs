using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class SlottypeEnumConverter : JsonConverter<SlottypeEnum>
    {
        public override bool CanConvert(Type t) => t == typeof(SlottypeEnum);

        public override SlottypeEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "food":
                    return SlottypeEnum.Food;
                case "potion":
                    return SlottypeEnum.Potion;
            }
            throw new Exception("Cannot unmarshal type SlottypeEnum");
        }

        public override void Write(Utf8JsonWriter writer, SlottypeEnum value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case SlottypeEnum.Food:
                    JsonSerializer.Serialize(writer, "food", options);
                    return;
                case SlottypeEnum.Potion:
                    JsonSerializer.Serialize(writer, "potion", options);
                    return;
            }
            throw new Exception("Cannot marshal type SlottypeEnum");
        }

        public static readonly SlottypeEnumConverter Singleton = new SlottypeEnumConverter();
    }
}
