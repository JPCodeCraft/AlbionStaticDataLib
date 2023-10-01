using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class ConsumablefrominventoryitemShopcategoryConverter : JsonConverter<ConsumablefrominventoryitemShopcategory>
    {
        public override bool CanConvert(Type t) => t == typeof(ConsumablefrominventoryitemShopcategory);

        public override ConsumablefrominventoryitemShopcategory Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "consumables":
                    return ConsumablefrominventoryitemShopcategory.Consumables;
                case "skillbooks":
                    return ConsumablefrominventoryitemShopcategory.Skillbooks;
            }
            throw new Exception("Cannot unmarshal type ConsumablefrominventoryitemShopcategory");
        }

        public override void Write(Utf8JsonWriter writer, ConsumablefrominventoryitemShopcategory value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case ConsumablefrominventoryitemShopcategory.Consumables:
                    JsonSerializer.Serialize(writer, "consumables", options);
                    return;
                case ConsumablefrominventoryitemShopcategory.Skillbooks:
                    JsonSerializer.Serialize(writer, "skillbooks", options);
                    return;
            }
            throw new Exception("Cannot marshal type ConsumablefrominventoryitemShopcategory");
        }

        public static readonly ConsumablefrominventoryitemShopcategoryConverter Singleton = new ConsumablefrominventoryitemShopcategoryConverter();
    }
}
