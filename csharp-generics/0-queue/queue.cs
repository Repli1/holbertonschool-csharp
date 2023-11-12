using System;

class Queue<T>
{
    public string CheckType()
    {
        return typeof(T).FullName;
    }
}
