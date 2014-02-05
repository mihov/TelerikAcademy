// 3.1. Write an expression that checks if given integer is odd or even.

using System;

class OddOrEven
{
    static void Main()
    {
        // Print some info text
        Console.Write("Please enter an integer number to check it ODD or EVEN is: ");

        // Declare the integer number
        int number;

        // Read the value from console
        string value = Console.ReadLine();

        // Try to convert
        bool result = int.TryParse(value, out number);

        if (result)
        {
            if ((number % 2) == 0) // Check the number
            {
                Console.WriteLine("You entered the even number {0}.", number); // Number is even
            }
            else
            {
                Console.WriteLine("You entered the odd number {0}.", number); // Number is odd
            }
        }
        else
        {
            Console.WriteLine("Attempted conversion of '{0}' failed.", value); // Convert failed
        }
    }
}
/**
Please enter an integer number to check it ODD or EVEN is: 555
You entered the odd number 555.
Press any key to continue . . .
**/