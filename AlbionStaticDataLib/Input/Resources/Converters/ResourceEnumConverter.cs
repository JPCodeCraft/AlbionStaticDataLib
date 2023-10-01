using System.Text.Json;
using System.Text.Json.Serialization;
using AlbionStaticDataLib.Input.Resources.Models;

namespace AlbionStaticDataLib.Input.Resources.Converters
{
    internal class ResourceEnumConverter : JsonConverter<ResourceEnum>
    {
        public override bool CanConvert(Type t) => t == typeof(ResourceEnum);

        public override ResourceEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "FIBER":
                    return ResourceEnum.Fiber;
                case "HIDE":
                    return ResourceEnum.Hide;
                case "ORE":
                    return ResourceEnum.Ore;
                case "ROCK":
                    return ResourceEnum.Rock;
                case "WOOD":
                    return ResourceEnum.Wood;
            }
            throw new Exception("Cannot unmarshal type ResourceEnum");
        }

        public override void Write(Utf8JsonWriter writer, ResourceEnum value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case ResourceEnum.Fiber:
                    JsonSerializer.Serialize(writer, "FIBER", options);
                    return;
                case ResourceEnum.Hide:
                    JsonSerializer.Serialize(writer, "HIDE", options);
                    return;
                case ResourceEnum.Ore:
                    JsonSerializer.Serialize(writer, "ORE", options);
                    return;
                case ResourceEnum.Rock:
                    JsonSerializer.Serialize(writer, "ROCK", options);
                    return;
                case ResourceEnum.Wood:
                    JsonSerializer.Serialize(writer, "WOOD", options);
                    return;
            }
            throw new Exception("Cannot marshal type ResourceEnum");
        }

        public static readonly ResourceEnumConverter Singleton = new ResourceEnumConverter();
    }
}
