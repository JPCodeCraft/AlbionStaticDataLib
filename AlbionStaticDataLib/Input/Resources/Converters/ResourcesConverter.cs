using AlbionStaticDataLib.Input.Resources.Models;
using System.Text.Json;

namespace AlbionStaticDataLib.Input.Resources.Converters
{
    public static class ResourcesConverter
    {
        public static readonly JsonSerializerOptions Settings = new(JsonSerializerDefaults.General)
        {
            Converters =
            {
                ResourceEnumConverter.Singleton,
                TierUnionConverter.Singleton,
                TilepremiumConverter.Singleton,
                new DateOnlyConverter(),
                new TimeOnlyConverter(),
                IsoDateTimeOffsetConverter.Singleton
            },
        };
    }
}
