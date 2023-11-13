using System;

public interface IInteractive
{
    void Interact();
}

public interface IBreakable
{
    int durability { get; set; }
    void Break();
}

public interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

public abstract class Base
{
    public string name { get; set; }

    public Base(string name = "Door")
    {
        this.name = name;
    }

    public override string ToString()
    {
        return $"{name} is a {this.GetType().Name}";
    }
}
public class Door : Base, IInteractive
{
    public Door(string name = "Door") : base(name)
    {
    }

    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}