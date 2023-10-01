using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class PrefabConverter : JsonConverter<Prefab>
    {
        public override bool CanConvert(Type t) => t == typeof(Prefab);

        public override Prefab Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "FX/ClientPrefabs/fx_hit_02":
                    return Prefab.FxClientPrefabsFxHit02;
                case "Prefabs/Vfx/MeleeHit/MeleeHit":
                    return Prefab.PrefabsVfxMeleeHitMeleeHit;
            }
            throw new Exception("Cannot unmarshal type Prefab");
        }

        public override void Write(Utf8JsonWriter writer, Prefab value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Prefab.FxClientPrefabsFxHit02:
                    JsonSerializer.Serialize(writer, "FX/ClientPrefabs/fx_hit_02", options);
                    return;
                case Prefab.PrefabsVfxMeleeHitMeleeHit:
                    JsonSerializer.Serialize(writer, "Prefabs/Vfx/MeleeHit/MeleeHit", options);
                    return;
            }
            throw new Exception("Cannot marshal type Prefab");
        }

        public static readonly PrefabConverter Singleton = new PrefabConverter();
    }
}
