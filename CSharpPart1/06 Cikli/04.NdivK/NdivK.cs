// 4. Write a program that calculates N!/K! for given N and K (1<K<N).

using System;
using System.Numerics;

class NdivK
{
    static void Main()
    {
        Console.Write("Enter value for K (K>1): ");
        uint valueK;
        if (uint.TryParse(Console.ReadLine(), out valueK))                      // Read value for K
        {
            if (valueK > 1)                                                     // Check K > 1?
            {
                Console.Write("Enter value for N (N>{0}): ", valueK);
                uint valueN;
                if (uint.TryParse(Console.ReadLine(), out valueN))              // Read value for N
                {
                    if (valueN > valueK)                                        // Check N > K?
                    {
                        BigInteger factorialN = 1;
                        for (int countN = 2; countN <= valueN; countN++)        // Loop 2 to N
                        {
                            factorialN = factorialN * countN;                   // Calculate N!
                        }

                        BigInteger factorialK = 1;
                        for (int countK = 2; countK <= valueK; countK++)        // Loop 2 to K
                        {
                            factorialK = factorialK * countK;                   // Calculate K!
                        }
                        int padding = factorialN.ToString().Length;             // Calculate Padding
                        
                        // Print the result
                        Console.WriteLine("\n\n");
                        Console.WriteLine(" N!     {0}", factorialN.ToString().PadLeft(padding, ' '));
                        Console.WriteLine("---- = -{0}- = {1}", "".PadLeft(padding, '-'), factorialN / factorialK); // Calculate the result
                        Console.WriteLine(" K!     {0}", factorialK.ToString().PadLeft(padding, ' '));
                    }
                    else
                    {
                        Console.WriteLine("N must be bigger than K!");
                    }
                }
                else
                {
                    Console.WriteLine("Unable to convert N!");
                }
            }
            else
            {
                Console.WriteLine("K must be bigger than 0!");
            }
        }
        else
        {
            Console.WriteLine("Unable to convert K!");
        }
    }
}

/** Console output:
Enter value for K (K>1): 4
Enter value for N (N>4): 7



 N!     5040
---- = ------ = 210
 K!       24
Press any key to continue . . .
 **/
