using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Enums

{
    [JsonConverter(typeof(JsonStringEnumConverter<Attacktype>))]
    public enum Attacktype { Magic, Melee, Ranged, Tools };
}
