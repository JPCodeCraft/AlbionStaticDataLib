using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public class Upgraderequirements
    {
        [JsonPropertyName("upgraderesource")]
        public ReplacementitemElement Upgraderesource { get; set; }
    }
}
