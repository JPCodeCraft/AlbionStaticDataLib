namespace AlbionStaticDataLib.Input.Items.Models

{
    public struct PurpleCraftresource
    {
        public CraftResource CraftingrequirementCraftresourceClass;
        public List<ReplacementitemElement> ReplacementitemElementArray;

        public static implicit operator PurpleCraftresource(CraftResource CraftingrequirementCraftresourceClass) => new PurpleCraftresource { CraftingrequirementCraftresourceClass = CraftingrequirementCraftresourceClass };
        public static implicit operator PurpleCraftresource(List<ReplacementitemElement> ReplacementitemElementArray) => new PurpleCraftresource { ReplacementitemElementArray = ReplacementitemElementArray };
    }
}
