namespace AlbionStaticDataLib.Input.Items.Enums

{
    [JsonConverter(typeof(JsonStringEnumConverter<Facestate>))]
    public enum Facestate { Empty, Face, Half, Hood };
}
