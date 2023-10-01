using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class HidefromplayeroncontextConverter : JsonConverter<Hidefromplayeroncontext>
    {
        public override bool CanConvert(Type t) => t == typeof(Hidefromplayeroncontext);

        public override Hidefromplayeroncontext Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "all":
                    return Hidefromplayeroncontext.All;
                case "asia":
                    return Hidefromplayeroncontext.Asia;
            }
            throw new Exception("Cannot unmarshal type Hidefromplayeroncontext");
        }

        public override void Write(Utf8JsonWriter writer, Hidefromplayeroncontext value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Hidefromplayeroncontext.All:
                    JsonSerializer.Serialize(writer, "all", options);
                    return;
                case Hidefromplayeroncontext.Asia:
                    JsonSerializer.Serialize(writer, "asia", options);
                    return;
            }
            throw new Exception("Cannot marshal type Hidefromplayeroncontext");
        }

        public static readonly HidefromplayeroncontextConverter Singleton = new HidefromplayeroncontextConverter();
    }
}
