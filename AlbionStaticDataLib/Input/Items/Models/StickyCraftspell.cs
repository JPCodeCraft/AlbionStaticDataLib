namespace AlbionStaticDataLib.Input.Items.Models

{
    public struct StickyCraftspell
    {
        public FluffyCraftspell FluffyCraftspell;
        public List<PurpleCraftspell> PurpleCraftspellArray;

        public static implicit operator StickyCraftspell(FluffyCraftspell FluffyCraftspell) => new StickyCraftspell { FluffyCraftspell = FluffyCraftspell };
        public static implicit operator StickyCraftspell(List<PurpleCraftspell> PurpleCraftspellArray) => new StickyCraftspell { PurpleCraftspellArray = PurpleCraftspellArray };
    }
}
