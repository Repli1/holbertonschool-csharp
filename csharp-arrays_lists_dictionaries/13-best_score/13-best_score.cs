using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int max = -1;
        foreach (string key in myList.Keys) {
            if (myList[key] > max)
                max = myList[key];
        }
        foreach (string key in myList.Keys) {
            if (myList[key] == max)
                return key;
        }
        return "None";
    }
}
