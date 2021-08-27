using System;

namespace Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program for subtraction of two numbers
            Console.WriteLine("===== PROGRAM FOR SUBTRACTION OF TWO NUMBERS =====");

            // Declare variables
            int firstNumber;
            int secondNumber;
            int result;

            // Prompt user to enter the first number
            Console.Write("Please enter the first number: ");
            firstNumber = int.Parse(Console.ReadLine());

            // Prompt user to enter the second number
            Console.Write("Please enter the second number: ");
            secondNumber = int.Parse(Console.ReadLine());

            // Perform subtraction
            result = firstNumber - secondNumber;

            // Display result
            Console.WriteLine("The difference of " + firstNumber + " - " + secondNumber + " is: " + result);

        }
    }
}
