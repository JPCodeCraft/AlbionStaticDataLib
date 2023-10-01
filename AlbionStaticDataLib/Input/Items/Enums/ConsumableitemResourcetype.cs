using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Enums

{
    [JsonConverter(typeof(JsonStringEnumConverter<ConsumableitemResourcetype>))]
    public enum ConsumableitemResourcetype { Fish };
}
