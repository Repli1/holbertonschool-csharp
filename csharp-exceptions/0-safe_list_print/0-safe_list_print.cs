﻿using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int i = 0;

        try
        {
            for (; i < n; i++)
                Console.WriteLine(myList[i]);
            return i;
        }
        catch (Exception ex)
        {
            return i;
        }
    }
}
