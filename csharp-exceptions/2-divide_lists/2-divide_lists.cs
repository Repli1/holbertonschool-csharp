using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < listLength; i++)
        {
            try
            {
                if (i < list1.Count && i < list2.Count)
                {
                    if (list2[i] != 0)
                    {
                        result.Add(list1[i] / list2[i]);
                    }
                    else
                    {
                        result.Add(0);
                        Console.WriteLine("Cannot divide by zero");
                    }
                }
                else
                {
                    Console.WriteLine("Out of range");
                }
            }
            catch (DivideByZeroException)
            {
                result.Add(0);
                Console.WriteLine("Cannot divide by zero");
            }
        }
        return result;
    }
}
