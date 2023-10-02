using AlbionStaticDataLib.Json.Shared.Converters;

namespace AlbionStaticDataLib.Json.Items.Models

{
    public class Upgraderequirements
    {
        [JsonPropertyName("upgraderesource")]
        [JsonConverter(typeof(SingleOrArrayConverter<UpgradeResource>))]
        public List<UpgradeResource> UpgradeResources { get; set; }
    }
}
