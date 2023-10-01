﻿namespace AlbionStaticDataLib.Input.Items.Models

{
    public static class ItemsConverter
    {
        public static readonly JsonSerializerOptions Settings = new(JsonSerializerDefaults.General)
        {
            Converters =
            {
                CraftingrequirementCraftresourceUnionConverter.Singleton,
                EnchantmentUnionConverter.Singleton,
                FacestateConverter.Singleton,
                StickyCraftspellConverter.Singleton,
                PurpleCraftresourceConverter.Singleton,
                LootUnionConverter.Singleton,
                FluffyCraftresourceConverter.Singleton,
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
