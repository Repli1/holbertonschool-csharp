using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = -1;
            for (int i = 0; i < 80; i++)
            {
                if ((i % 10) == 0)
                {
                    j++;
                }
                if (j < (i % 10))
                {
                    Console.Write("{0}{1}, ", j, i % 10);
                }
            }
            Console.WriteLine("89");
        }
    }
}
