// 1. Write a program that prints all the numbers from 1 to N.

using System;

class PrintFrom1ToN
{
    static void Main()
    {
        Console.Write("Enter N (N > 1): "); 
        int numbersN = int.Parse(Console.ReadLine());           // Read N from console
        for (int counter = 1; counter <= numbersN; counter++)   // Loop from 1 to N
        {
            Console.WriteLine(counter);                         // Print from 1 to N on the console 
        }
    }
}

/** Console output:
Enter N (N > 1): 5
1
2
3
4
5
Press any key to continue . . .
**/