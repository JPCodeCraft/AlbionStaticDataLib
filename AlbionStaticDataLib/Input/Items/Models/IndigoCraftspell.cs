namespace AlbionStaticDataLib.Input.Items.Models

{
    public struct IndigoCraftspell
    {
        public PurpleCraftspell PurpleCraftspell;
        public List<TentacledCraftspell> TentacledCraftspellArray;

        public static implicit operator IndigoCraftspell(PurpleCraftspell PurpleCraftspell) => new IndigoCraftspell { PurpleCraftspell = PurpleCraftspell };
        public static implicit operator IndigoCraftspell(List<TentacledCraftspell> TentacledCraftspellArray) => new IndigoCraftspell { TentacledCraftspellArray = TentacledCraftspellArray };
    }
}
