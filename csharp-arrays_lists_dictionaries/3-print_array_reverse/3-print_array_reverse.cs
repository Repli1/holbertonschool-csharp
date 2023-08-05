using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array is null || array.Length == 0) {
            Console.WriteLine("");
        }
        else {
            for (int i = 1; i <= array.Length; i++) {
                Console.Write(array[array.Length - i]);
                if (i != array.Length) {
                    Console.Write(" ");
                }
                else {
                    Console.WriteLine("");
                }
            }
        }
    }
}
