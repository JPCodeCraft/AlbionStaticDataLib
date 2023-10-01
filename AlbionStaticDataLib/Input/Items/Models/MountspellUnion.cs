namespace AlbionStaticDataLib.Input.Items.Models

{
    public struct MountspellUnion
    {
        public MountspellElement MountspellElement;
        public List<MountspellElement> MountspellElementArray;

        public static implicit operator MountspellUnion(MountspellElement MountspellElement) => new MountspellUnion { MountspellElement = MountspellElement };
        public static implicit operator MountspellUnion(List<MountspellElement> MountspellElementArray) => new MountspellUnion { MountspellElementArray = MountspellElementArray };
    }
}
