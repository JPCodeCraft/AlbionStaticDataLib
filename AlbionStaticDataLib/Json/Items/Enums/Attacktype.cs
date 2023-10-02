using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Json.Items.Enums

{
    [JsonConverter(typeof(JsonStringEnumConverter<Attacktype>))]
    public enum Attacktype { Magic, Melee, Ranged, Tools };
}
