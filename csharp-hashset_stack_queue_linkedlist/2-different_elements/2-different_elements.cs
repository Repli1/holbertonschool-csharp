using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> newList = new List<int>();
        foreach (int n in list1)
        {
            if(list2.Contains(n) == false)
                newList.Add(n);
        }
        foreach (int n in list2)
        {
            if(list1.Contains(n) == false)
                newList.Add(n);
        }
        newList.Sort();
        return newList;
    }
}
