using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 98; i++)
            {
                Console.Write("{0} = 0x{1}\n", i, i.ToString("x"));
            }
        }
    }
}
