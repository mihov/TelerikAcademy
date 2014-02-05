// 4.5. Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;

class CompareTwoNumbersNOif
{
    static void Main()
    {
        // Read first number
        Console.Write("Enter one number: ");
        int numberOne;
        int.TryParse(Console.ReadLine(), out numberOne);

        // Read second number
        Console.Write("Enter another one number: ");
        int numberTwo;
        int.TryParse(Console.ReadLine(), out numberTwo);

        // Print result on the console
        Console.WriteLine("\nThe greater from {0} and {1} is {2}.", numberOne, numberTwo, Math.Max(numberOne, numberTwo));
    }
}
/** Console output:
Enter one number: 25
Enter another one number: 20

The greater from 25 and 20 is 25.
Press any key to continue . . .
 **/
