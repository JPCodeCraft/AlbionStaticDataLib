namespace AlbionStaticDataLib.Input.Items.Models

{
    public struct SimpleitemCraftingrequirements
    {
        public IndigoCraftingrequirements IndigoCraftingrequirements;
        public List<TentacledCraftingrequirement> TentacledCraftingrequirementArray;

        public static implicit operator SimpleitemCraftingrequirements(IndigoCraftingrequirements IndigoCraftingrequirements) => new SimpleitemCraftingrequirements { IndigoCraftingrequirements = IndigoCraftingrequirements };
        public static implicit operator SimpleitemCraftingrequirements(List<TentacledCraftingrequirement> TentacledCraftingrequirementArray) => new SimpleitemCraftingrequirements { TentacledCraftingrequirementArray = TentacledCraftingrequirementArray };
    }
}
