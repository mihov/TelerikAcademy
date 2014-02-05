// 4.7. Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum.

using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("How many numbers do you want to sum? ");
        int numbers;
        if (!(int.TryParse(Console.ReadLine(), out numbers)))
        {
            Console.WriteLine("Unable to convert!");
            Environment.Exit(0);                        // Close the application if unable to konvert
        }

        int sumOfNumbers = 0;
        int temp;
        Console.WriteLine("Enter values for:");
        for (int i = 1; i <= numbers; i++)
        {
            Console.Write("   number {0}: ", i);
            if (!(int.TryParse(Console.ReadLine(), out temp)))
            {
                Console.WriteLine("Unable to convert! Try again.");
                i--;
                continue;// Close the application if unable to konvert
            }
            sumOfNumbers = sumOfNumbers + temp;

        }
        Console.WriteLine("\nThe sum of your {0} numbers is {1}.", numbers, sumOfNumbers);
    }
}