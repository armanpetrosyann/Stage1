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
 
           
        }
    }
}
