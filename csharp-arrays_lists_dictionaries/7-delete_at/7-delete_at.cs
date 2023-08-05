using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        List<int> newList = new List<int>();

        if (myList.Count <= index || index < 0) {
            Console.WriteLine("Index is out of range");
            return myList;
        }
        for (int i = 0; i < myList.Count; i++) {
            if (i != index)
                newList.Add(myList[i]);
        }
        myList.Clear();
        for (int i = 0; i < newList.Count; i++)
            myList.Add(newList[i]);
        return myList;
    }
}
