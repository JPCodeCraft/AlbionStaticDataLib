using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    internal class DespawneffectConverter : JsonConverter<Despawneffect>
    {
        public override bool CanConvert(Type t) => t == typeof(Despawneffect);

        public override Despawneffect Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            switch (value)
            {
                case "FX/ClientPrefabs/demount_fx_big":
                    return Despawneffect.FxClientPrefabsDemountFxBig;
                case "FX/ClientPrefabs/demount_fx_medium":
                    return Despawneffect.FxClientPrefabsDemountFxMedium;
                case "FX/ClientPrefabs/demount_fx_small":
                    return Despawneffect.FxClientPrefabsDemountFxSmall;
                case "FX/ClientPrefabs/demount_fx_very_small":
                    return Despawneffect.FxClientPrefabsDemountFxVerySmall;
            }
            throw new Exception("Cannot unmarshal type Despawneffect");
        }

        public override void Write(Utf8JsonWriter writer, Despawneffect value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case Despawneffect.FxClientPrefabsDemountFxBig:
                    JsonSerializer.Serialize(writer, "FX/ClientPrefabs/demount_fx_big", options);
                    return;
                case Despawneffect.FxClientPrefabsDemountFxMedium:
                    JsonSerializer.Serialize(writer, "FX/ClientPrefabs/demount_fx_medium", options);
                    return;
                case Despawneffect.FxClientPrefabsDemountFxSmall:
                    JsonSerializer.Serialize(writer, "FX/ClientPrefabs/demount_fx_small", options);
                    return;
                case Despawneffect.FxClientPrefabsDemountFxVerySmall:
                    JsonSerializer.Serialize(writer, "FX/ClientPrefabs/demount_fx_very_small", options);
                    return;
            }
            throw new Exception("Cannot marshal type Despawneffect");
        }

        public static readonly DespawneffectConverter Singleton = new DespawneffectConverter();
    }
}
