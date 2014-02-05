// 3.2. Write a boolean expression that checks for given integer 
// if it can be divided (without remainder) by 7 and 5 in the same time.

using System;

class DividedBy7And5
{
    static void Main()
    {
        // Print some info text
        Console.Write("Please enter an integer number to check \nif it can be divided by 7 and 5: ");

        // Declare the integer number
        int number;

        // Read the value from console
        string value = Console.ReadLine();

        // Try to convert
        bool result = int.TryParse(value, out number);

        if (result)
        {
            if (((number % 5) == 0) && ((number % 7) == 0)) // Check the number
            {
                Console.WriteLine("You entered the number {0}, it can be divided by 7 and 5.", number); // Number can be divided by 7 and 5
            }
            else
            {
                Console.WriteLine("You entered the number {0}, it can not be divided by 7 and 5.", number); // Number can not be divided by 7 and 5
            }
        }
        else
        {
            Console.WriteLine("Attempted conversion of '{0}' failed.", value); // Convert failed
        }
    }
}
/** Console output:
Please enter an integer number to check
if it can be divided by 7 and 5: 45
You entered the number 45, it can not be divided by 7 and 5.
Press any key to continue . . .

Please enter an integer number to check
if it can be divided by 7 and 5: 35
You entered the number 35, it can be divided by 7 and 5.
Press any key to continue . . .
**/