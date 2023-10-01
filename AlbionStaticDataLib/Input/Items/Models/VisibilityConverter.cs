using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class VisibilityConverter : JsonConverter<Visibility>
    {
        public override bool CanConvert(Type t) => t == typeof(Visibility);

        public override Visibility Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "AffectedAndInstigatorOnly")
            {
                return Visibility.AffectedAndInstigatorOnly;
            }
            throw new Exception("Cannot unmarshal type Visibility");
        }

        public override void Write(Utf8JsonWriter writer, Visibility value, JsonSerializerOptions options)
        {
            if (value == Visibility.AffectedAndInstigatorOnly)
            {
                JsonSerializer.Serialize(writer, "AffectedAndInstigatorOnly", options);
                return;
            }
            throw new Exception("Cannot marshal type Visibility");
        }

        public static readonly VisibilityConverter Singleton = new VisibilityConverter();
    }
}
