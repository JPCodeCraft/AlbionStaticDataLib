namespace AlbionStaticDataLib.Input.Items.Models

{
    public struct PurpleCraftresource
    {
        public CraftingrequirementCraftresourceClass CraftingrequirementCraftresourceClass;
        public List<ReplacementitemElement> ReplacementitemElementArray;

        public static implicit operator PurpleCraftresource(CraftingrequirementCraftresourceClass CraftingrequirementCraftresourceClass) => new PurpleCraftresource { CraftingrequirementCraftresourceClass = CraftingrequirementCraftresourceClass };
        public static implicit operator PurpleCraftresource(List<ReplacementitemElement> ReplacementitemElementArray) => new PurpleCraftresource { ReplacementitemElementArray = ReplacementitemElementArray };
    }
}
