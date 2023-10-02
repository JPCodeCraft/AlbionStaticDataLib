using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Json.Items.Enums

{
    [JsonConverter(typeof(JsonStringEnumConverter<Animationid>))]
    public enum Animationid { Breed, Planting, Sow };
}
