using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class TargetConverter : JsonConverter<Target>
    {
        public override bool CanConvert(Type t) => t == typeof(Target);

        public override Target Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "self":
                    return Target.Self;
                case "target":
                    return Target.Target;
            }
            throw new Exception("Cannot unmarshal type Target");
        }

        public override void Write(Utf8JsonWriter writer, Target value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Target.Self:
                    JsonSerializer.Serialize(writer, "self", options);
                    return;
                case Target.Target:
                    JsonSerializer.Serialize(writer, "target", options);
                    return;
            }
            throw new Exception("Cannot marshal type Target");
        }

        public static readonly TargetConverter Singleton = new TargetConverter();
    }
}
