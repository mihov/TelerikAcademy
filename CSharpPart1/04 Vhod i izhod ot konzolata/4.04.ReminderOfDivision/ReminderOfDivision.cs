// 4.4. Write a program that reads two positive integer numbers and prints how many numbers p exist
// between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

using System;

class ReminderOfDivision
{
    static void Main()
    {
        // Read first number
        Console.Write("Enter  one  positive  number: ");
        uint numberOne;
        if (!(uint.TryParse(Console.ReadLine(), out numberOne)))
        {
            Console.WriteLine("Unable to convert!");
            Environment.Exit(0);                        // Close the application if unable to konvert
        }

        // Read second number
        Console.Write("Enter another positive number bigger than {0}: ", numberOne);
        uint numberTwo;
        if (!(uint.TryParse(Console.ReadLine(), out numberTwo)))
        {
            Console.WriteLine("Unable to convert!");
            Environment.Exit(0);                        // Close the application if unable to konvert
        }
        else if (numberOne > numberTwo)
        {
            Console.WriteLine("First number must be lower than second.");
            Environment.Exit(0);            
        }

        // Declare and initialise the counter
        uint counter = 0;

        // Count from first to second number
        for (int i = (int)numberOne; i <= numberTwo; i++)
        {
            if (i % 5 == 0)
            {
                counter++; // Increase the caunter if reminder of the division by 5 is 0
            }
        }

        // Print the result on the console
        Console.WriteLine("\nExist {0} numbers between {1} and {2} that the reminder of the division by 5 is 0.", counter, numberOne, numberTwo);
    }
}

/** Console output:
Enter  one  positive  number : 17
Enter another positive number: 25

Exist 2 numbers between 17 and 25 that the reminder of the division by 5 is 0.
Press any key to continue . . .
**/