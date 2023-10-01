using System.Text.Json;

namespace AlbionStaticDataLib.Input.Localization.Converters
{
    public static class LocalizationConverter
    {
        public static readonly JsonSerializerOptions Settings = new(JsonSerializerDefaults.General)
        {
            Converters =
            {
                new DateOnlyConverter(),
                new TimeOnlyConverter(),
                IsoDateTimeOffsetConverter.Singleton
            },
        };
    }
}
