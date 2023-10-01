using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class SocketConverter : JsonConverter<Socket>
    {
        public override bool CanConvert(Type t) => t == typeof(Socket);

        public override Socket Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "damage":
                    return Socket.Damage;
                case "mainhand":
                    return Socket.Mainhand;
                case "offhand":
                    return Socket.Offhand;
            }
            throw new Exception("Cannot unmarshal type Socket");
        }

        public override void Write(Utf8JsonWriter writer, Socket value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Socket.Damage:
                    JsonSerializer.Serialize(writer, "damage", options);
                    return;
                case Socket.Mainhand:
                    JsonSerializer.Serialize(writer, "mainhand", options);
                    return;
                case Socket.Offhand:
                    JsonSerializer.Serialize(writer, "offhand", options);
                    return;
            }
            throw new Exception("Cannot marshal type Socket");
        }

        public static readonly SocketConverter Singleton = new SocketConverter();
    }
}
