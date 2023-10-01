using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Attack
    {
        [JsonPropertyName("@attackdamagefactor")]
        public string Attackdamagefactor { get; set; }

        [JsonPropertyName("@attackspeedfactor")]
        public string Attackspeedfactor { get; set; }

        [JsonPropertyName("@attackdamagetimefactor")]
        public string Attackdamagetimefactor { get; set; }

        [JsonPropertyName("@attacktype")]
        public Attacktype Attacktype { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("attackvfx")]
        public List<AttackvfxElement> Attackvfx { get; set; }
    }
}
