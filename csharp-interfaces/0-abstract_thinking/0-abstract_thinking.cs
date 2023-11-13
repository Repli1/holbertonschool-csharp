public abstract class Base
{
    public string Name { get; set; }

    public Base(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        string typeName = GetType().Name;

        return $"{Name} is a {typeName}";
    }
}
