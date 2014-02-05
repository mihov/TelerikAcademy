// 20. Write a program that reads two numbers N and K
// and generates all the variations of K elements from the set [1..N]. Example:
// N = 3, K = 2 ==> {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

using System;

class VariationsOfK
{
    static void Main()
    {
        Console.WriteLine("Program generates all the variations of K elements from the set [1..N].");

        // Reads value for N
        Console.Write("Enter value for N: ");
        int valueN = int.Parse(Console.ReadLine());
        
        // Reads value for N
        Console.Write("Enter value for K: ");
        int valueK = int.Parse(Console.ReadLine());
        
        // Declare array for current variant with K elements
        int[] variationsArray = new int[valueK];

        Console.Write("N = {0}, K = {1} ==> ", valueN, valueK);
        
        // Calculate and print the variation N of K
        // Call method VariationsCalc
        VariationsCalc(variationsArray, 0, valueN);
    }

    //Method VariationsCalc
    static void VariationsCalc(int[] array, int index, int endOfArray)
    {
        if (index == array.Length)
        {
            // Print current Variatnt
            Console.Write("{"+String.Join(", ", array)+"} ");
        }
        else
        {
            for (int element = 1; element <= endOfArray; element++)
            {
                // Add element to current variant
                array[index] = element;
                // Call it self for next element
                VariationsCalc(array, index + 1, endOfArray);
            }
        }
    }
}

/** Console output:
Program generates all the variations of K elements from the set [1..N].
Enter value for N: 3
Enter value for K: 2
N = 3, K = 2 ==> {1, 1} {1, 2} {1, 3} {2, 1} {2, 2} {2, 3} {3, 1} {3, 2} {3, 3}
Press any key to continue . . .
**/