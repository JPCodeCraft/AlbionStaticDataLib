namespace AlbionStaticDataLib.Input.Items.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter<MountCategory>))]
    public enum MountCategory
    {
        HORSE, DONKEYS, HORSES, ARMORED_HORSES, OXEN, STAGS, DIREWOLVES, DIREBOARS, LIZARDS, DIREBEARS, MAMMOTHS, OWL, COUGARS
    }
}
