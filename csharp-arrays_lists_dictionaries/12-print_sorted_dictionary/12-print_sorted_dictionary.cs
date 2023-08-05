using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> dictKeys = new List<string>(myDict.Keys);
        dictKeys.Sort();
        foreach (string key in dictKeys)
        {
            Console.WriteLine($"{key}: {myDict[key]}");
        }
    }
}
