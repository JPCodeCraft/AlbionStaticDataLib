using System.Text.Json.Serialization;

namespace AlbionStaticDataLib.Input.Shared
{
    [JsonConverter(typeof(JsonStringEnumConverter<ResourceTypeEnum>))]
    public enum ResourceTypeEnum { Fiber, Hide, Ore, Rock, Wood };
}
