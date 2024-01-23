namespace MVVM
{
    internal sealed class SampleModel : Model
    {
        public string FirstName { get; set; }
        public string FamilyName { get; set; }

        public Parent Parent { get; set; } = new();
        public SubChild SubChild { get => Parent.Child.SubChild; set => Parent.Child.SubChild = value; }
    }

    public class Parent
    {
        public Child Child = new();
    }

    public class Child
    {
        public SubChild SubChild = new();
    }

    public class SubChild
    {
        public int i = 0;
    }
}