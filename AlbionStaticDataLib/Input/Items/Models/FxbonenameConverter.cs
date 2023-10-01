using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class FxbonenameConverter : JsonConverter<Fxbonename>
    {
        public override bool CanConvert(Type t) => t == typeof(Fxbonename);

        public override Fxbonename Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "LeftArm_3":
                    return Fxbonename.LeftArm3;
                case "RightArm_3":
                    return Fxbonename.RightArm3;
            }
            throw new Exception("Cannot unmarshal type Fxbonename");
        }

        public override void Write(Utf8JsonWriter writer, Fxbonename value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Fxbonename.LeftArm3:
                    JsonSerializer.Serialize(writer, "LeftArm_3", options);
                    return;
                case Fxbonename.RightArm3:
                    JsonSerializer.Serialize(writer, "RightArm_3", options);
                    return;
            }
            throw new Exception("Cannot marshal type Fxbonename");
        }

        public static readonly FxbonenameConverter Singleton = new FxbonenameConverter();
    }
}
