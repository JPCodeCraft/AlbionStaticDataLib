using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Enums

{
    [JsonConverter(typeof(JsonStringEnumConverter<Slottype>))]
    public enum Slottype { Food, Potion, Mount };
}
