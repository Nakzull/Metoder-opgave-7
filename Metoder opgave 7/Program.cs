using System;

namespace Metoder_opgave_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[9];
            InsertNumbersToArray(ref myArray);
            for (int i = 4; i < 5; i++)
                Console.WriteLine("The fifth value of the array is " + myArray[i]);
            myArray[4] = myArray[3] * 2;
        }
        public static int[] InsertNumbersToArray(ref int[] a)
        {
            for (int i = 0; i < 9; i++)
                a[i] = i + 1;
            return a;
        }
    }
}
