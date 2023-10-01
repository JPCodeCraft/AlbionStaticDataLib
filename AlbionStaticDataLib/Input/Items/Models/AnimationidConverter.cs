using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class AnimationidConverter : JsonConverter<Animationid>
    {
        public override bool CanConvert(Type t) => t == typeof(Animationid);

        public override Animationid Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "breed":
                    return Animationid.Breed;
                case "planting":
                    return Animationid.Planting;
                case "sow":
                    return Animationid.Sow;
            }
            throw new Exception("Cannot unmarshal type Animationid");
        }

        public override void Write(Utf8JsonWriter writer, Animationid value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Animationid.Breed:
                    JsonSerializer.Serialize(writer, "breed", options);
                    return;
                case Animationid.Planting:
                    JsonSerializer.Serialize(writer, "planting", options);
                    return;
                case Animationid.Sow:
                    JsonSerializer.Serialize(writer, "sow", options);
                    return;
            }
            throw new Exception("Cannot marshal type Animationid");
        }

        public static readonly AnimationidConverter Singleton = new AnimationidConverter();
    }
}
