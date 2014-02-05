// 8. Write a program that calculates the greatest common divisor (GCD) of given two numbers.
// Use the Euclidean algorithm (find it in Internet).

using System;

class GCD
{
    static void Main()
    {
        Console.Write("Enter value for first number: ");
        int numberA;
        if (int.TryParse(Console.ReadLine(), out numberA))      // Read value for first number
        {
            Console.Write("Enter value for second number: ");
            int numberB;
            if (int.TryParse(Console.ReadLine(), out numberB))  // Read value for second number
            {
                // Calculate and print greatest common divisor
                Console.WriteLine("\nGreatest Common Divisor of {0} and {1} is {2}.", numberA, numberB, GCDfunction(numberA, numberB));
            }
            else Console.WriteLine("Unable to convert!");
        }
        else Console.WriteLine("Unable to convert!");
    }

    private static int GCDfunction(int numberA, int numberB)        // Create function GCD
    {
        if (numberB == 0)
        {
            return numberA;                                         // Return the result
        }
        else
        {
            return GCDfunction(numberB, numberA % numberB);     // Recursive call of function GCD and return the result
        }
        throw new NotImplementedException();
    }
}

/**
Console output:
Enter value for first number: 1071
Enter value for second number: 462

Greatest Common Divisor of 1071 and 462 is 21.
Press any key to continue . . .
**/