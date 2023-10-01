using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class BeardstateConverter : JsonConverter<Beardstate>
    {
        public override bool CanConvert(Type t) => t == typeof(Beardstate);

        public override Beardstate Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "EMPTY":
                    return Beardstate.Empty;
                case "FLAT":
                    return Beardstate.Flat;
                case "HALF":
                    return Beardstate.Half;
            }
            throw new Exception("Cannot unmarshal type Beardstate");
        }

        public override void Write(Utf8JsonWriter writer, Beardstate value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Beardstate.Empty:
                    JsonSerializer.Serialize(writer, "EMPTY", options);
                    return;
                case Beardstate.Flat:
                    JsonSerializer.Serialize(writer, "FLAT", options);
                    return;
                case Beardstate.Half:
                    JsonSerializer.Serialize(writer, "HALF", options);
                    return;
            }
            throw new Exception("Cannot marshal type Beardstate");
        }

        public static readonly BeardstateConverter Singleton = new BeardstateConverter();
    }
}
