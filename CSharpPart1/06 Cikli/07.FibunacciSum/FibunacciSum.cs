// 7. Write a program that reads a number N and calculates the sum of the first N members of the sequence
// of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
// Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.

using System;
using System.Numerics;

class FibunacciSum
{
    static void Main()
    {
        Console.Write("How many Fibonacci members do you want to sum? ");
        int countOfMembers;
        if (int.TryParse(Console.ReadLine(), out countOfMembers)) //Read the count of members
        {
            BigInteger theSum = 1;
            BigInteger memberNm2 = 0; // First and second members are fixsed 0 and 1
            BigInteger memberNm1 = 1; //
            BigInteger memberN;
            for (int fibunacciMember = 3; fibunacciMember <= countOfMembers; fibunacciMember++)    // Loop for the remaining  N - 2 members
            {
                memberN = memberNm1 + memberNm2;    // Calculate member N
                memberNm2 = memberNm1;              // Assign value for N-2 member
                memberNm1 = memberN;                // Assign value for N-1 member
                theSum += memberN;                  // Calculate the sum
            }
            Console.WriteLine("\nThe sum of first {0} Fibonacci members is {1}.", countOfMembers, theSum);
        }
        else
        {
            Console.WriteLine("\nUnable to convert N!");
        }
    }
}

/** Console output
How many Fibonacci members do you want to sum? 10

The sum of first 10 Fibonacci members is 88.
Press any key to continue . . .
 **/
