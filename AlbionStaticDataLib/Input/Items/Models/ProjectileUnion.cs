namespace AlbionStaticDataLib.Input.Items.Models

{
    public struct ProjectileUnion
    {
        public ProjectileElement ProjectileElement;
        public List<ProjectileElement> ProjectileElementArray;

        public static implicit operator ProjectileUnion(ProjectileElement ProjectileElement) => new ProjectileUnion { ProjectileElement = ProjectileElement };
        public static implicit operator ProjectileUnion(List<ProjectileElement> ProjectileElementArray) => new ProjectileUnion { ProjectileElementArray = ProjectileElementArray };
    }
}
