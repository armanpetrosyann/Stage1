using System;

namespace Stage1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Write a program in C# Sharp to input a string and print it. 

            Console.Write("Input the string: ");
            string dataFromConsole = Convert.ToString(Console.ReadLine());

            Console.WriteLine($"The string you entered is: {dataFromConsole}");

            // 2. Write a program in C# Sharp to find the length of a string without using library function.

            Console.Write("Input the string: ");
            string askForUser = Convert.ToString(Console.ReadLine());
            string lenghtOfText = askForUser.Length.ToString();

            Console.WriteLine(lenghtOfText);


        }
    }
}
