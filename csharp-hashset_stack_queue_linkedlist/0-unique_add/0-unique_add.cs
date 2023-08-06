using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        int sum = 0;
        List<int> newList = new List<int>();
        for (int i = 0; i < myList.Count; i++)
        {
            if (newList.Contains(myList[i]) == false)
                newList.Add(myList[i]);
        }
        for (int i = 0; i < newList.Count; i++)
            sum += newList[i];
        return sum;
    }
}
