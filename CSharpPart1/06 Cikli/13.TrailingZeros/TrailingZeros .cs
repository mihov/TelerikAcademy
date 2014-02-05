// 13. Write a program that calculates for given N how many trailing zeros present at the end of the number N!. 

using System;

class TrailingZeros
{
    static void Main()
    {
        int integerN;
        if (int.TryParse(Console.ReadLine(), out integerN) && integerN > 0)     // Read and check N
        {
            Console.WriteLine("In {0}! has {1} trailing zeros.", integerN, Trailing0(integerN));                             // Calculate and print the result 
        }
        else
        {
            Console.WriteLine("Not meet the requirements!");                    // Error message
        }
    }

    private static int Trailing0(int integerN)                                  // Creat function Trailing0
    {
        if (integerN <= 0)
        {
            return 0;   // Exit of recursion
        }
        else
        {
            return (integerN / 5) + Trailing0(integerN / 5);                    // Recursive call of Trailing0 and sum with integerN / 5
        }
        throw new NotImplementedException();
    }
}
