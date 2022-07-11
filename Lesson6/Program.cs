using System;

namespace Lesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sort array numbers by descending

            // Method 1. Using Array.Sort() and Array.Reverse() Method

            int[] arr = new int[] { 1, 9, 6, 7, 5, 9 };

            Array.Sort(arr);

            Array.Reverse(arr);

            foreach (int item in arr)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
