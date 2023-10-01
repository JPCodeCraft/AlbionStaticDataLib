using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Enums

{
    [JsonConverter(typeof(JsonStringEnumConverter<Beardstate>))]
    public enum Beardstate { Empty, Flat, Half };
}
