using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Json.Items.Enums

{
    [JsonConverter(typeof(JsonStringEnumConverter<Beardstate>))]
    public enum Beardstate { Empty, Flat, Half };
}
