namespace AlbionStaticDataLib.Input.Resources.Models
{
    public class Modifier
    {
        [JsonPropertyName("@tierdifference")]
        [JsonConverter(typeof(StringToIntConverter))]
        public int Tierdifference { get; set; }

        [JsonPropertyName("@timefactor")]
        public string Timefactor { get; set; }
    }
}
