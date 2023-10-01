namespace AlbionStaticDataLib.Input.Items.Models

{
    public struct CraftingrequirementCraftresourceUnion
    {
        public CraftResource CraftingrequirementCraftresourceClass;
        public List<CraftResource> CraftingrequirementCraftresourceClassArray;

        public static implicit operator CraftingrequirementCraftresourceUnion(CraftResource CraftingrequirementCraftresourceClass) => new CraftingrequirementCraftresourceUnion { CraftingrequirementCraftresourceClass = CraftingrequirementCraftresourceClass };
        public static implicit operator CraftingrequirementCraftresourceUnion(List<CraftResource> CraftingrequirementCraftresourceClassArray) => new CraftingrequirementCraftresourceUnion { CraftingrequirementCraftresourceClassArray = CraftingrequirementCraftresourceClassArray };
    }
}
