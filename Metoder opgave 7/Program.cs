using System;

namespace Metoder_opgave_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[9];
            InsertNumbersToArray(ref myArray);

            foreach (int items in myArray)
                Console.WriteLine(items);
        }
        public static int[] InsertNumbersToArray(ref int[] a)
        {
            for (int i = 0; i < 9; i++)
               a[i] = i + 1;
            return a;
        }
    }
}
