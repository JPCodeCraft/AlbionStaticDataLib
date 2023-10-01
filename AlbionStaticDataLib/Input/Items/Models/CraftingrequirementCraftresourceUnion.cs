namespace AlbionStaticDataLib.Input.Items.Models

{
    public struct CraftingrequirementCraftresourceUnion
    {
        public CraftingrequirementCraftresourceClass CraftingrequirementCraftresourceClass;
        public List<CraftingrequirementCraftresourceClass> CraftingrequirementCraftresourceClassArray;

        public static implicit operator CraftingrequirementCraftresourceUnion(CraftingrequirementCraftresourceClass CraftingrequirementCraftresourceClass) => new CraftingrequirementCraftresourceUnion { CraftingrequirementCraftresourceClass = CraftingrequirementCraftresourceClass };
        public static implicit operator CraftingrequirementCraftresourceUnion(List<CraftingrequirementCraftresourceClass> CraftingrequirementCraftresourceClassArray) => new CraftingrequirementCraftresourceUnion { CraftingrequirementCraftresourceClassArray = CraftingrequirementCraftresourceClassArray };
    }
}
