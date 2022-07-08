using System;

namespace Stage1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Write a program in C# Sharp to input a string and print it. 

            //Console.Write("Input the string : ");

            //string dataFromConsole = Convert.ToString(Console.ReadLine());

            //Console.WriteLine($"The string you entered is : {dataFromConsole}");

            // 2. Write a program in C# Sharp to find the length of a string without using library function.

            //Console.Write("Input the string : ");

            //string askForUser = Convert.ToString(Console.ReadLine());

            //string lengthOfText = askForUser.Length.ToString();

            //Console.WriteLine($"Length of the string is : {lengthOfText}");

            // 3.Write a program in C# Sharp to separate the individual characters from a string.

            //Console.Write("Input the string : ");

            //int i = 0;

            //string data = Convert.ToString(Console.ReadLine());

            //while (i < data.Length - 1)
            //{
            //    Console.Write("{0} ",data[i]);
            //        i++;
            //}
            //Console.Write("\n\n");

            // 4. Write a program in C# Sharp to print individual
            // characters of the string in reverse order. Go to the editor Test Data :

            int i = 0;

            Console.Write("Input the string : ");
            string str = Console.ReadLine();

            i = str.Length - 1;
            
            while (i >= 0)
            {
                Console.Write("{0} ", str[i]);
                i--;
            }
            Console.Write("\n\n");
        }

    }
}
