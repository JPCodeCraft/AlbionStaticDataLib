namespace AlbionStaticDataLib.Input.Items.Models

{
    public struct WeaponCraftingrequirements
    {
        public IndecentCraftingrequirements IndecentCraftingrequirements;
        public List<StickyCraftingrequirement> StickyCraftingrequirementArray;

        public static implicit operator WeaponCraftingrequirements(IndecentCraftingrequirements IndecentCraftingrequirements) => new WeaponCraftingrequirements { IndecentCraftingrequirements = IndecentCraftingrequirements };
        public static implicit operator WeaponCraftingrequirements(List<StickyCraftingrequirement> StickyCraftingrequirementArray) => new WeaponCraftingrequirements { StickyCraftingrequirementArray = StickyCraftingrequirementArray };
    }
}
