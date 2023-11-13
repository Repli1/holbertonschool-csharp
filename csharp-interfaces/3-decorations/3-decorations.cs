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
public class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem { get; set; }
    private int _durability;

    public int durability
    {
        get { return _durability; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Durability must be greater than 0");
            }
            _durability = value;
        }
    }

    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false) : base(name)
    {
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
        }
        else if (isQuestItem)
        {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        }
        else
        {
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }

    public void Break()
    {
        if (durability > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.");
        }
        else if (durability == 0)
        {
            Console.WriteLine($"You smash the {name}. What a mess.");
        }
        else
        {
            Console.WriteLine($"The {name} is already broken.");
        }

        durability--;
    }
}