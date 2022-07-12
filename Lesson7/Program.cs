using System;

namespace Lesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Write a program in C# Sharp to separate the individual characters from a string. 

            Console.WriteLine("Test Data:");

            Console.Write("Input the string: ");

            string askForString = Convert.ToString(Console.ReadLine());

            for (int i = 0; i < askForString.Length; i++)
            {
                Console.Write(askForString[i] + " ");
            }

            // 2.Write a program in C# Sharp to find the length of a string without using library function.

            Console.WriteLine("Test Data: ");

            Console.Write("Input the string: ");

            string askForStr = Convert.ToString(Console.ReadLine());

            int checker = 0;

            foreach (char item in askForStr)
            {
                checker++;
            }
            Console.WriteLine($"Total number of letter in string is: {checker}");

            
        }
    }
}
