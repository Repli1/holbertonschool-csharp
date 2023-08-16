using System;

class Int
{
    public static void divide(int a, int b)
    {
        int c = 0;

        try
        {
            c = a / b;
        }
        catch (Exception)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine($"{a} / {b} = {c}");
        }
    }
}
