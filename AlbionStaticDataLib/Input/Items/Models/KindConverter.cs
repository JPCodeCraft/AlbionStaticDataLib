using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class KindConverter : JsonConverter<Kind>
    {
        public override bool CanConvert(Type t) => t == typeof(Kind);

        public override Kind Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "animal":
                    return Kind.Animal;
                case "plant":
                    return Kind.Plant;
            }
            throw new Exception("Cannot unmarshal type Kind");
        }

        public override void Write(Utf8JsonWriter writer, Kind value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Kind.Animal:
                    JsonSerializer.Serialize(writer, "animal", options);
                    return;
                case Kind.Plant:
                    JsonSerializer.Serialize(writer, "plant", options);
                    return;
            }
            throw new Exception("Cannot marshal type Kind");
        }

        public static readonly KindConverter Singleton = new KindConverter();
    }
}
