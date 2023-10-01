using System.Text.Json;

namespace AlbionStaticDataLib.Input.Items.Models

{
    public static class ItemsConverter
    {
        public static readonly JsonSerializerOptions Settings = new(JsonSerializerDefaults.General)
        {
            Converters =
            {
                HidefromplayeroncontextConverter.Singleton,
                ShopConverter.Singleton,
                ConsumablefrominventoryitemCraftingrequirementsConverter.Singleton,
                CraftingrequirementCraftresourceUnionConverter.Singleton,
                FactionConverter.Singleton,
                EnchantmentUnionConverter.Singleton,
                NamelocatagConverter.Singleton,
                EquipmentitemDescriptionlocatagConverter.Singleton,
                FacestateConverter.Singleton,
                IontypeConverter.Singleton,
                ItempowerprogressiontypeEnumConverter.Singleton,
                EquipmentitemCraftingrequirementsConverter.Singleton,
                StickyCraftspellConverter.Singleton,
                KindConverter.Singleton,
                FurnitureitemDescriptionlocatagConverter.Singleton,
                LabourerfurnituretypeConverter.Singleton,
                LabourersaffectedConverter.Singleton,
                FurnitureitemCraftingrequirementsConverter.Singleton,
                PurpleCraftresourceConverter.Singleton,
                LootUnionConverter.Singleton,
                ForceddismountbuffConverter.Singleton,
                HostiledismountbuffConverter.Singleton,
                LonghostiledismountbuffConverter.Singleton,
                FluffyCraftresourceConverter.Singleton,
                MountspellUnionConverter.Singleton,
                SimpleitemCraftingrequirementsConverter.Singleton,
                FxbonenameConverter.Singleton,
                FxboneoffsetConverter.Singleton,
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
