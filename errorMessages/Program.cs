using System;

namespace errorMessages
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.Write("Enter number to get error message: ");

            var askForMessageNumber = Convert.ToInt32(Console.ReadLine());



            switch (askForMessageNumber)
            {
                case 0:
                    Console.WriteLine(ErrorMessages.INCORRECT_DATA);
                    break;
                case 1:
                    Console.WriteLine(ErrorMessages.INCORRECT_ERROR);
                    break;
                case 2:
                    Console.WriteLine(ErrorMessages.INCORRECT_MESSAGE);
                    break;
                case 3:
                    Console.WriteLine(ErrorMessages.INCORRECT_EXCEPTION);
                    break;
                    case 4:
                    Console.WriteLine(ErrorMessages.INCORRECT_STACK);
                    break;
                case 5:
                    Console.WriteLine(ErrorMessages.INCORRECT_STACK_ERROR);
                    break;
                default:
                    Console.WriteLine("Error message doesn't found");
                    break;
            }

        }
    }
}
