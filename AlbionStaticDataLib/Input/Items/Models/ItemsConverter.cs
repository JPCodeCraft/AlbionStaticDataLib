namespace AlbionStaticDataLib.Input.Items.Models

{
    public static class ItemsConverter
    {
        public static readonly JsonSerializerOptions Settings = new(JsonSerializerDefaults.General)
        {
            Converters =
            {
                ConsumablefrominventoryitemCraftingrequirementsConverter.Singleton,
                CraftingrequirementCraftresourceUnionConverter.Singleton,
                EnchantmentUnionConverter.Singleton,
                FacestateConverter.Singleton,
                EquipmentitemCraftingrequirementsConverter.Singleton,
                StickyCraftspellConverter.Singleton,
                FurnitureitemCraftingrequirementsConverter.Singleton,
                PurpleCraftresourceConverter.Singleton,
                LootUnionConverter.Singleton,
                FluffyCraftresourceConverter.Singleton,
                MountspellUnionConverter.Singleton,
                SimpleitemCraftingrequirementsConverter.Singleton,
                WeaponCraftingrequirementsConverter.Singleton,
                IndigoCraftspellConverter.Singleton,
                ProjectileUnionConverter.Singleton,
                new DateOnlyConverter(),
                new TimeOnlyConverter(),
                IsoDateTimeOffsetConverter.Singleton
            },
        };
    }
}
