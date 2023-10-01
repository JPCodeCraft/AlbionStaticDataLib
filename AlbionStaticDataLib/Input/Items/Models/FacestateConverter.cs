using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class FacestateConverter : JsonConverter<Facestate>
    {
        public override bool CanConvert(Type t) => t == typeof(Facestate);

        public override Facestate Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "EMPTY":
                    return Facestate.Empty;
                case "FACE":
                    return Facestate.Face;
                case "HALF":
                    return Facestate.Half;
                case "HOOD":
                    return Facestate.Hood;
            }
            throw new Exception("Cannot unmarshal type Facestate");
        }

        public override void Write(Utf8JsonWriter writer, Facestate value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Facestate.Empty:
                    JsonSerializer.Serialize(writer, "EMPTY", options);
                    return;
                case Facestate.Face:
                    JsonSerializer.Serialize(writer, "FACE", options);
                    return;
                case Facestate.Half:
                    JsonSerializer.Serialize(writer, "HALF", options);
                    return;
                case Facestate.Hood:
                    JsonSerializer.Serialize(writer, "HOOD", options);
                    return;
            }
            throw new Exception("Cannot marshal type Facestate");
        }

        public static readonly FacestateConverter Singleton = new FacestateConverter();
    }
}
