using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class FxboneoffsetConverter : JsonConverter<Fxboneoffset>
    {
        public override bool CanConvert(Type t) => t == typeof(Fxboneoffset);

        public override Fxboneoffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "0.2 -0.227 0.135":
                    return Fxboneoffset.The0202270135;
                case "1.33 0.11 -0.43":
                    return Fxboneoffset.The133011043;
            }
            throw new Exception("Cannot unmarshal type Fxboneoffset");
        }

        public override void Write(Utf8JsonWriter writer, Fxboneoffset value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Fxboneoffset.The0202270135:
                    JsonSerializer.Serialize(writer, "0.2 -0.227 0.135", options);
                    return;
                case Fxboneoffset.The133011043:
                    JsonSerializer.Serialize(writer, "1.33 0.11 -0.43", options);
                    return;
            }
            throw new Exception("Cannot marshal type Fxboneoffset");
        }

        public static readonly FxboneoffsetConverter Singleton = new FxboneoffsetConverter();
    }
}
