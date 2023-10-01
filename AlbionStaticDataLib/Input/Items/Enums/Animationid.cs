using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Enums

{
    [JsonConverter(typeof(JsonStringEnumConverter<Animationid>))]
    public enum Animationid { Breed, Planting, Sow };
}
