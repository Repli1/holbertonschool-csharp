using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int n = 0;
        for ( int i = 0; i < myDict.Count; i++)
            n++;
        return n;
    }
}
