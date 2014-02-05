// 4.8. Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

using System;

class NumbersInInterval
{
    static void Main()
    {
        Console.Write("Enter number n to print from 1 to n? ");
        int numberN;
        if (!(int.TryParse(Console.ReadLine(), out numberN)))
        {
            Console.WriteLine("Unable to convert!");
            Environment.Exit(0);                        // Close the application if unable to konvert
        }
        else if (!(numberN >= 0))
        {
            Console.WriteLine("n must be bigger then 1!");
            Environment.Exit(0);                        // Close the application if n <= 0
        }

        Console.WriteLine("\nAll numbers from 1 to {0} are:\n", numberN);
        for (int counter = 1; counter <= numberN; counter++)
        {
            Console.WriteLine(counter);                 // Print numbers from 1 to n
        }
    }
}
/** Console output:
Enter number n to print from 1 to n? 5

All numbers from 1 to 5 are:

1
2
3
4
5
Press any key to continue . . .
 **/
