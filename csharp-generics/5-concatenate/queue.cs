using System;

class Queue<T>
{
    public class Node
    {
        public T Value { get; }
        public Node Next { get; set; }

        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    private Node head;
    private Node tail;
    private int count;
    public string CheckType()
    {
        return typeof(T).FullName;
    }
    public void Enqueue(T item)
    {
        Node newNode = new Node(item);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            tail = newNode;
        }

        count++;
    }
    public int Count()
    {
        return count;
    }
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        T value = head.Value;
        head = head.Next;

        if (head == null)
        {
            tail = null;
        }

        count--;

        return value;
    }
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        return head.Value;
    }
    public void Print()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        Node current = head;

        while (current != null)
        {
            Console.WriteLine($"{current.Value}");
            current = current.Next;
        }
    }
    public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }

        if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return null;
        }

        string result = "";
        Node current = head;

        while (current != null)
        {
            result += current.Value;
            current = current.Next;
        }

        return result;
    }
}
