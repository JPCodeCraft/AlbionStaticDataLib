using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class MountspellUnionConverter : JsonConverter<MountspellUnion>
    {
        public override bool CanConvert(Type t) => t == typeof(MountspellUnion);

        public override MountspellUnion Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.StartObject:
                    var objectValue = JsonSerializer.Deserialize<MountspellElement>(ref reader, options);
                    return new MountspellUnion { MountspellElement = objectValue };
                case JsonTokenType.StartArray:
                    var arrayValue = JsonSerializer.Deserialize<List<MountspellElement>>(ref reader, options);
                    return new MountspellUnion { MountspellElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type MountspellUnion");
        }

        public override void Write(Utf8JsonWriter writer, MountspellUnion value, JsonSerializerOptions options)
        {
            if (value.MountspellElementArray != null)
            {
                JsonSerializer.Serialize(writer, value.MountspellElementArray, options);
                return;
            }
            if (value.MountspellElement != null)
            {
                JsonSerializer.Serialize(writer, value.MountspellElement, options);
                return;
            }
            throw new Exception("Cannot marshal type MountspellUnion");
        }

        public static readonly MountspellUnionConverter Singleton = new MountspellUnionConverter();
    }
}
