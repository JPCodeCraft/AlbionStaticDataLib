namespace AlbionStaticDataLib.Input.Items.Models

{
    public static class ItemsConverter
    {
        public static readonly JsonSerializerOptions Settings = new(JsonSerializerDefaults.General)
        {
            Converters =
            {
                FacestateConverter.Singleton,
                StickyCraftspellConverter.Singleton,
                LootUnionConverter.Singleton,
                MountspellUnionConverter.Singleton,
                IndigoCraftspellConverter.Singleton,
                ProjectileUnionConverter.Singleton,
                new DateOnlyConverter(),
                new TimeOnlyConverter(),
                IsoDateTimeOffsetConverter.Singleton
            },
        };
    }
}
