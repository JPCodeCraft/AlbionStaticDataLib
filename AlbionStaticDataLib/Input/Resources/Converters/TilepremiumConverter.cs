using AlbionStaticDataLib.Input.Resources.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Resources.Converters
{
    internal class TilepremiumConverter : JsonConverter<Tilepremium>
    {
        public override bool CanConvert(Type t) => t == typeof(Tilepremium);

        public override Tilepremium Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (value == "SILVERCOINS_PREMIUM")
            {
                return Tilepremium.SilvercoinsPremium;
            }
            throw new Exception("Cannot unmarshal type Tilepremium");
        }

        public override void Write(Utf8JsonWriter writer, Tilepremium value, JsonSerializerOptions options)
        {
            if (value == Tilepremium.SilvercoinsPremium)
            {
                JsonSerializer.Serialize(writer, "SILVERCOINS_PREMIUM", options);
                return;
            }
            throw new Exception("Cannot marshal type Tilepremium");
        }

        public static readonly TilepremiumConverter Singleton = new TilepremiumConverter();
    }
}
