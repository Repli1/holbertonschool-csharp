using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        if ((number % 10) > 5)
        {
            Console.WriteLine("The last digit of {0} is {1} and is greater than 5", number, number % 10);
        }
        else if ((number % 10) == 0)
        {
            Console.WriteLine("The last digit of {0} is 0 and is 0", number);
        }
        else
        {
            Console.WriteLine("The last digit of {0} is {1} and is less than 6 and not 0", number, number % 10);
        }
    }
}