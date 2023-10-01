namespace AlbionStaticDataLib.Input.Items.Models

{
    public struct EnchantmentUnion
    {
        public FluffyEnchantment FluffyEnchantment;
        public List<PurpleEnchantment> PurpleEnchantmentArray;

        public static implicit operator EnchantmentUnion(FluffyEnchantment FluffyEnchantment) => new EnchantmentUnion { FluffyEnchantment = FluffyEnchantment };
        public static implicit operator EnchantmentUnion(List<PurpleEnchantment> PurpleEnchantmentArray) => new EnchantmentUnion { PurpleEnchantmentArray = PurpleEnchantmentArray };
    }
}
