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
                NamelocatagConverter.Singleton,
                FacestateConverter.Singleton,
                EquipmentitemCraftingrequirementsConverter.Singleton,
                StickyCraftspellConverter.Singleton,
                LabourerfurnituretypeConverter.Singleton,
                LabourersaffectedConverter.Singleton,
                FurnitureitemCraftingrequirementsConverter.Singleton,
                PurpleCraftresourceConverter.Singleton,
                LootUnionConverter.Singleton,
                LonghostiledismountbuffConverter.Singleton,
                FluffyCraftresourceConverter.Singleton,
                MountspellUnionConverter.Singleton,
                SimpleitemCraftingrequirementsConverter.Singleton,
                MainhandanimationtypeAttackConverter.Singleton,
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
