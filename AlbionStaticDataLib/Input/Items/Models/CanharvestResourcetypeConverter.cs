using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class CanharvestResourcetypeConverter : JsonConverter<CanharvestResourcetype>
    {
        public override bool CanConvert(Type t) => t == typeof(CanharvestResourcetype);

        public override CanharvestResourcetype Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "FIBER":
                    return CanharvestResourcetype.Fiber;
                case "HIDE":
                    return CanharvestResourcetype.Hide;
                case "ORE":
                    return CanharvestResourcetype.Ore;
                case "ROCK":
                    return CanharvestResourcetype.Rock;
                case "WOOD":
                    return CanharvestResourcetype.Wood;
            }
            throw new Exception("Cannot unmarshal type CanharvestResourcetype");
        }

        public override void Write(Utf8JsonWriter writer, CanharvestResourcetype value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case CanharvestResourcetype.Fiber:
                    JsonSerializer.Serialize(writer, "FIBER", options);
                    return;
                case CanharvestResourcetype.Hide:
                    JsonSerializer.Serialize(writer, "HIDE", options);
                    return;
                case CanharvestResourcetype.Ore:
                    JsonSerializer.Serialize(writer, "ORE", options);
                    return;
                case CanharvestResourcetype.Rock:
                    JsonSerializer.Serialize(writer, "ROCK", options);
                    return;
                case CanharvestResourcetype.Wood:
                    JsonSerializer.Serialize(writer, "WOOD", options);
                    return;
            }
            throw new Exception("Cannot marshal type CanharvestResourcetype");
        }

        public static readonly CanharvestResourcetypeConverter Singleton = new CanharvestResourcetypeConverter();
    }
}
