using System;
using System.Reflection;
using System.Collections.Generic;


class Obj
{
    public static void Print(object myObj)
    {
        Console.WriteLine($"{myObj.GetType().Name} Properties:");
        foreach (PropertyInfo property in (myObj.GetType()).GetProperties())
        {
            Console.WriteLine(property.Name);
        }
        Console.WriteLine($"{myObj.GetType().Name} Methods:");
        foreach (MethodInfo method in (myObj.GetType()).GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}
