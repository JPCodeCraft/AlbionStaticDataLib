using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Resources.Converters
{
    internal class FluffyParseStringConverter : JsonConverter<bool>
    {
        public override bool CanConvert(Type t) => t == typeof(bool);

        public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            bool b;
            if (bool.TryParse(value, out b))
            {
                return b;
            }
            throw new Exception("Cannot unmarshal type bool");
        }

        public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options)
        {
            var boolString = value ? "true" : "false";
            JsonSerializer.Serialize(writer, boolString, options);
            return;
        }

        public static readonly FluffyParseStringConverter Singleton = new FluffyParseStringConverter();
    }
}
