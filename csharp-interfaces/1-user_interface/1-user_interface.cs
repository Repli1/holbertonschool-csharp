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

    public override string ToString()
    {
        return $"{name} is a {this.GetType().Name}";
    }
}
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public void Interact()
    {
    }

    public int durability { get; set; }
    public void Break()
    {
    }

    public bool isCollected { get; set; }
    public void Collect()
    {
    }
}