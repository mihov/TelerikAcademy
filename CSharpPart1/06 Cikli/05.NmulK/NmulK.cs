// 5. Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K)

using System;
using System.Numerics;

class NmulK
{
    static void Main()
    {
        Console.Write("Enter value for N (N>1): ");
        uint valueN;
        if (uint.TryParse(Console.ReadLine(), out valueN))              // Read value for N
        {
            if (valueN > 1)                                             // Check is N > 1
            {
                Console.Write("Enter value for K (K>{0}): ", valueN);
                uint valueK;
                if (uint.TryParse(Console.ReadLine(), out valueK))      // Read value for K
                {
                    if (valueK > valueN)                                // Check is K > N
                    {
                        BigInteger factorialK = 1;
                        for (int countK = 2; countK <= valueK; countK++)    // Loop from 2 to K
                        {
                            factorialK *= countK;                           // Calculate K!
                        }

                        BigInteger factorialN = 1;
                        for (int countN = 2; countN <= valueN; countN++)    // Loop from 2 to N
                        {
                            factorialN *= countN;                           // Calculate N!
                        }

                        BigInteger factorialKmN = 1;
                        for (int countKmN = 2; countKmN <= (valueK - valueN); countKmN++)   // Loop from 2 to K-N
                        {
                            factorialKmN *= countKmN;                                       // Calculate (K-N)!
                        }

                        BigInteger facNmultfacN = factorialN * factorialK;                  // Calculate N! * K!
                        int padding = facNmultfacN.ToString().Length;                       // Calculate padding
                        
                        // Print result on the console
                        Console.WriteLine("\n\n");
                        Console.WriteLine(" N! * K!     {0}", facNmultfacN.ToString().PadLeft(padding, ' '));
                        Console.WriteLine("--------- = -{0}- = {1}", "".PadLeft(padding, '-'), facNmultfacN / factorialKmN); // Calculate the result
                        Console.WriteLine(" (K - N)!    {0}", factorialKmN.ToString().PadLeft(padding, ' '));
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
Enter value for N (N>1): 6
Enter value for K (K>6): 9



 N! * K!     261273600
--------- = ----------- = 43545600
 (K - N)!            6
Press any key to continue . . .
**/