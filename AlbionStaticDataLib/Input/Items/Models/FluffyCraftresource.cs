namespace AlbionStaticDataLib.Input.Items.Models

{
    public struct FluffyCraftresource
    {
        public List<CraftResource> CraftingrequirementCraftresourceClassArray;
        public ReplacementitemElement ReplacementitemElement;

        public static implicit operator FluffyCraftresource(List<CraftResource> CraftingrequirementCraftresourceClassArray) => new FluffyCraftresource { CraftingrequirementCraftresourceClassArray = CraftingrequirementCraftresourceClassArray };
        public static implicit operator FluffyCraftresource(ReplacementitemElement ReplacementitemElement) => new FluffyCraftresource { ReplacementitemElement = ReplacementitemElement };
    }
}
