using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class ConstraintpresetConverter : JsonConverter<Constraintpreset>
    {
        public override bool CanConvert(Type t) => t == typeof(Constraintpreset);

        public override Constraintpreset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "inWorldWithRotate")
            {
                return Constraintpreset.InWorldWithRotate;
            }
            throw new Exception("Cannot unmarshal type Constraintpreset");
        }

        public override void Write(Utf8JsonWriter writer, Constraintpreset value, JsonSerializerOptions options)
        {
            if (value == Constraintpreset.InWorldWithRotate)
            {
                JsonSerializer.Serialize(writer, "inWorldWithRotate", options);
                return;
            }
            throw new Exception("Cannot marshal type Constraintpreset");
        }

        public static readonly ConstraintpresetConverter Singleton = new ConstraintpresetConverter();
    }
}
