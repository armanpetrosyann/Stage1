using System;
using System.Linq;

namespace Lesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sort array numbers by descending

            // Method 1.using Array.Sort() and Array.Reverse() Method

            int[] arr = new int[] { 1, 9, 6, 7, 5, 9 };

            Array.Sort(arr);

            Array.Reverse(arr);

            foreach (int item in arr)
            {
                Console.WriteLine(item + " ");
            }

            // Method 2. Using Iterative way

            int[] array = new int[] { 10, 30, 20, 40, 60, 50 };

            int temp;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            foreach (int value in array)
            {
                Console.WriteLine(value + " ");
            }

            // Method 3. Using LINQ descending

            int[] myArr = new int[] { 1, 9, 6, 7, 5, 9 };

            myArr = myArr.OrderByDescending(c => c).ToArray();

            foreach (int value in myArr)
            {
                Console.WriteLine(value + " ");
            }
           
        }
    }
}
