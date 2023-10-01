using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class MainhandanimationtypeAttackConverter : JsonConverter<MainhandanimationtypeAttack>
    {
        public override bool CanConvert(Type t) => t == typeof(MainhandanimationtypeAttack);

        public override MainhandanimationtypeAttack Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "knuckles_speed":
                    return MainhandanimationtypeAttack.KnucklesSpeed;
                case "quarterstaff_speed":
                    return MainhandanimationtypeAttack.QuarterstaffSpeed;
            }
            throw new Exception("Cannot unmarshal type MainhandanimationtypeAttack");
        }

        public override void Write(Utf8JsonWriter writer, MainhandanimationtypeAttack value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case MainhandanimationtypeAttack.KnucklesSpeed:
                    JsonSerializer.Serialize(writer, "knuckles_speed", options);
                    return;
                case MainhandanimationtypeAttack.QuarterstaffSpeed:
                    JsonSerializer.Serialize(writer, "quarterstaff_speed", options);
                    return;
            }
            throw new Exception("Cannot marshal type MainhandanimationtypeAttack");
        }

        public static readonly MainhandanimationtypeAttackConverter Singleton = new MainhandanimationtypeAttackConverter();
    }
}
