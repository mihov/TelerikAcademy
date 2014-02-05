// 01. Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

using System;

class LeapYear
{
    static void Main()
    {
        Console.Write("Wnter a year: ");
        // Reads year from console.
        int yearAsInt = int.Parse(Console.ReadLine());

        Console.Write("The year {0} is ", yearAsInt);

        // Check is XXXX leap year and print proper result.
        if (!DateTime.IsLeapYear(yearAsInt))
        {
            Console.Write("not ");
        }
        Console.WriteLine("leap.");
    }
}

/** Console output:
Wnter a year: 2016
The year 2016 is leap.
Press any key to continue . . .
 * 
 * 
Wnter a year: 2014
The year 2014 is not leap.
Press any key to continue . . .
**/

