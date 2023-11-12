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
}
