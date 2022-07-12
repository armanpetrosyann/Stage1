using System;

namespace Lesson7
{
    internal class Program
    {
        // Method to reverse string entered from console 

        public static string Reverse(string Input)
        {
            char[] charArray = Input.ToCharArray();

            string reversedString = String.Empty;

            for (int i = charArray.Length - 1; i > -1; i--)
            {
                reversedString += charArray[i];
            }

            return reversedString;
        }

        static void Main(string[] args)
        {
            // 1.Write a program in C# Sharp to separate the individual characters from a string. 

            Console.WriteLine("Test Data:");

            Console.Write("Input the string: ");

            string askForString = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Expected output: ");

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
            Console.WriteLine("Expected output: ");

            Console.WriteLine($"Total number of letter in string is: {checker}");

            // 3.Write a program in C# Sharp to print individual characters of the string in reverse order. 

            Console.WriteLine("Test Data");

            Console.Write("Input the string: ");

            string askForText = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Expected output: ");

            Console.WriteLine(Reverse(askForText));
        }
    }
}
