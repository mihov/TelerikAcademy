// 6. Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

using System;
using System.Numerics;

class CalculateSum
{
    static void Main()
    {
        Console.Write("Enter value for N: ");
        int numberN;
        if (int.TryParse(Console.ReadLine(), out numberN))      // Read value for N
        {
            Console.Write("Enter value for X: ");
            int numberX;
            if (int.TryParse(Console.ReadLine(), out numberX))  // Read value for X
            {
                decimal total = 1;                              // Inicialize total 
                for (int counter = 1; counter <= numberN; counter++)    // Loop from 1 to N
                {
                    total += (decimal)factoriel(counter) / (decimal)Math.Pow(numberX, counter); // Calculate the result
                }

                // Print the result
                Console.WriteLine("\nThe sum S = {0}", total);
            }
            else
            {
                Console.WriteLine("Unable to convert X!");
            }
        }
        else
        {
            Console.WriteLine("Unable to convert N!");
        }
    }

    // Create function factoriel
    private static BigInteger factoriel(int counter)
    {
        if (counter > 0)        // Check is counter positive?
        {
            BigInteger result = 1;  // Inicialize the result
            for (int i = 2; i <= counter; i++)  // Loop from 2 to counter
            {
                result *= i;                    // Calculate N!   
            }
            return result;                      // Return the resul
        }
        else
        {
            return 0;                           // Return error
        }
        throw new NotImplementedException();
    }
}