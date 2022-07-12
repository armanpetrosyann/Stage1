using System;

namespace Lesson7
{
    internal class Program
    {
        // Method to reverse string entered from Console 

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

        // Method to Compare of two strings from Console

        public static bool CompareTwoValues(string firtString, string secondString)
        {
            bool isEqual = true;

            int checker = 0;

            if (firtString.Length != secondString.Length)
            {
                isEqual = false;
            }

            while (checker < firtString.Length && isEqual)
            {
                if (firtString[checker] != secondString[checker])
                {
                    isEqual = false;
                }
                checker++;
            }
            return isEqual;
        }

        // Check count of total number of alphabets 

        //public static string CountOfAlphabets(string alphabet)
        //{
        //    int alp = 0;

        //    while (alp < alphabet.Length)
        //    {
        //        if ((alphabet[alp] >= 'a' && (alphabet[alp] <= 'z') || (alphabet[alp] >= 'A' && alphabet[alp] <= 'Z')))
        //        {
        //            alp++;
        //        }

        //    }
        //    return alp.ToString(); 
        //}

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

            // 4.Write a program in C# Sharp to compare two string without using string library functions. 

            Console.Write("Input the 1st string: ");

            string firstString = Convert.ToString(Console.ReadLine());

            Console.Write("Input the 2nd string: ");

            string secondString = Convert.ToString(Console.ReadLine());

            Console.WriteLine(CompareTwoValues(firstString, secondString));

            // 5.Write a program in C# Sharp to count a total number of alphabets, digits and special characters in a string. 

            //int check = 0;

            //Console.Write("Input the string: ");

            //string strOne = Convert.ToString(Console.ReadLine());

            //while (check < strOne.Length)
            //{
            //    if ((strOne[check] >= 'a' && strOne[check] <= 'z') || (strOne[check] >= 'A' && strOne[check] <= 'Z'))
            //    {
            //        check++;
            //    }
            //}
            //Console.WriteLine(check);

            // 7.Write a program in C# Sharp to sort a string array in ascending order.  

            string[] array = { "Artur", "James", "Karen", "Derenick", "Robert" };

            Array.Sort(array);

            foreach (string name in array)
            {
                Console.WriteLine(name);
            }

        }
    }
}
