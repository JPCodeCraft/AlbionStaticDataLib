namespace AlbionStaticDataLib.Input.Items.Models

{
    public static class ItemsConverter
    {
        public static readonly JsonSerializerOptions Settings = new(JsonSerializerDefaults.General)
        {
            Converters =
            {
                LootUnionConverter.Singleton,
                MountspellUnionConverter.Singleton,
            },
        };
    }
}
