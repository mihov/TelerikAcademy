// 5.1. Write an if statement that examines two integer variables
// and exchanges their values if the first one is greater than the second one.

using System;

class CompareTwoInteger
{
    static void Main()
    {
        Console.Write("Enter  first variable: ");
        int firstInt = int.Parse(Console.ReadLine()); // Reads first variable

        Console.Write("Enter second variable: ");
        int secondInt = int.Parse(Console.ReadLine());// Reads second variable

        if (firstInt > secondInt)                     // Compare it
        {
            int temp = firstInt;                      //  
            firstInt = secondInt;                     // exchange if the first is greater than the second
            secondInt = temp;                         //  
        }
        Console.WriteLine("\nThe value of first  variable is {0}", firstInt);
        Console.WriteLine("The value of second variable is {0}", secondInt);
    }
}

/** Console output:
Enter  first variable: 5
Enter second variable: 4

The value of first  variable is 4
The value of second variable is 5
Press any key to continue . . .
**/