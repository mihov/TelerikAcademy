// 21. Write a program that reads two numbers N and K
// and generates all the combinations of K distinct elements from the set [1..N].
// Example:
//      N = 5, K = 2 ==> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

using System;

class CombinationsOfK
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
        CombinationsCalc(variationsArray, 0, 1, valueN);
        Console.WriteLine();
    }

    //Method VariationsCalc
    static void CombinationsCalc(int[] array, int index, int currentElement, int endOfArray)
    {
        if (index == array.Length)
        {
            // Print current Variatnt
            Console.Write("{" + String.Join(", ", array) + "} ");
        }
        else
        {
            for (int element = currentElement; element <= endOfArray; element++)
            {
                // Add element to current variant
                array[index] = element;
                // Call it self for next element
                CombinationsCalc(array, index + 1, element + 1, endOfArray);
            }
        }
    }
}

/** Console output:
Program generates all the variations of K elements from the set [1..N].
Enter value for N: 5
Enter value for K: 2
N = 5, K = 2 ==> {1, 2} {1, 3} {1, 4} {1, 5} {2, 3} {2, 4} {2, 5} {3, 4} {3, 5}
{4, 5}
Press any key to continue . . .
**/