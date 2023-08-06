using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList <int> llist = new LinkedList<int>();
        if (size < 0)
            return llist;
        for (int i = 0; i < size; i++)
        {
            llist.AddLast(i);
            Console.WriteLine(i);
        }
        return llist;
    }
}
