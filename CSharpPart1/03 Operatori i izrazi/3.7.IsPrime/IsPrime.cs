// 3.7. Write an expression that checks if given positive integer number n (n ≤ 100) is prime.
// E.g. 37 is prime.

using System;

class IsPrime
{
    static void Main()
    {
        // Read integer number from console
        Console.Write("Enter a positive integer numbet, to check is it prime: ");
        int isPrimeInt = int.Parse(Console.ReadLine());

        int checkTo = (int)Math.Sqrt(isPrimeInt); // Check only to sqrt of candidate

        bool isPrimeBool = true; // Candidate is prime by default


        if (isPrimeInt > 0)
        {
            for (int i = 2; i <= checkTo; i++) // Check all values before candidate for prime
            {
                if (isPrimeInt % i == 0)
                {
                    isPrimeBool = false;  // Candidate is not prime
                }
            }

            // Print result on the console
            if (isPrimeBool)
            {
                Console.WriteLine("{0} is prime.", isPrimeInt); // Candidate is prime
            }
            else
            {
                Console.WriteLine("{0} is not prime.", isPrimeInt); // Candidate is not prime
            }
        }
        else
        {
            Console.WriteLine("{0} is not positive.", isPrimeInt); // Candidate is not positive
        }
    }
}
/** Console output
Enter a positive integer numbet, to check is it prime: 55
55 is not prime.
Press any key to continue . . .
**/