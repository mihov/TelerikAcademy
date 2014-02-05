// 4.1. Write a program that reads 3 integer numbers from the console and prints their sum.

using System;

class Reads3integer
{
    static void Main()
    {
        Console.WriteLine("Enter 3 integer numbers to see their sum.");

        // Reading number 1
        Console.Write("Number 1: ");
        int number1;
        if (!(int.TryParse(Console.ReadLine(), out number1)))
        {
            Console.WriteLine("Unable to convert!"); 
            Environment.Exit(0);                        // Close the application if unable to konvert
        }

        // Reading number 2
        Console.Write("Number 2: ");
        int number2;
        if (!(int.TryParse(Console.ReadLine(), out number2)))
        {
            Console.WriteLine("Unable to convert!");
            Environment.Exit(0);                        // Close the application if unable to konvert
        }

        // Reading number 3
        Console.Write("Number 2: ");
        int number3;
        if (!(int.TryParse(Console.ReadLine(), out number3)))
        {
            Console.WriteLine("Unable to convert!");
            Environment.Exit(0);                        // Close the application if unable to konvert
        }

        // Calculate and print the sum
        int result = number1 + number2 + number3;
        Console.WriteLine("The sum of {0}, {1} and {2} is {3}", number1, number2, number3, result);
    }
}

/** Console output:
Enter 3 integer numbers to see their sum.
Number 1: 10
Number 2: 20
Number 2: 30
The sum of 10, 20 and 30 is 60
Press any key to continue . . .
**/