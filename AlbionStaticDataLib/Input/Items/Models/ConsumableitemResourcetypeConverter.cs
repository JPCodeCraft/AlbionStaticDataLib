using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class ConsumableitemResourcetypeConverter : JsonConverter<ConsumableitemResourcetype>
    {
        public override bool CanConvert(Type t) => t == typeof(ConsumableitemResourcetype);

        public override ConsumableitemResourcetype Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "FISH")
            {
                return ConsumableitemResourcetype.Fish;
            }
            throw new Exception("Cannot unmarshal type ConsumableitemResourcetype");
        }

        public override void Write(Utf8JsonWriter writer, ConsumableitemResourcetype value, JsonSerializerOptions options)
        {
            if (value == ConsumableitemResourcetype.Fish)
            {
                JsonSerializer.Serialize(writer, "FISH", options);
                return;
            }
            throw new Exception("Cannot marshal type ConsumableitemResourcetype");
        }

        public static readonly ConsumableitemResourcetypeConverter Singleton = new ConsumableitemResourcetypeConverter();
    }
}
