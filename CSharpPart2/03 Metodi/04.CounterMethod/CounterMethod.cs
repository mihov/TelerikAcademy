// 04. Write a method that counts how many times given number appears in given array.
// Write a test program to check if the method is working correctly.

using System;

class CounterMethod
{
    static void Main()
    {
        // Define value for array length.
        int arrayLength = 20;

        // Reads search value
        Console.Write("Enter an integer to search: ");
        int searchValue = int.Parse(Console.ReadLine());

        // Define the array
        int[] testArray = new int[arrayLength];

        //  Fills the array with random values close to the searchValue.
        Random rnd = new Random();
        for (int element = 0; element < arrayLength; element++)
        {
            testArray[element] = rnd.Next(searchValue - 2, searchValue + 2);
        }

        // Prints the array
        Console.Write("\nIn array [");
        Console.WriteLine(String.Join(", ", testArray) + "]");

        // Prints the method results.
        Console.WriteLine("{0} was found {1} times.", searchValue, ArrayCounter(testArray, searchValue));
    }

    /// <summary>
    /// Counts how many times given number appears in given array.
    /// </summary>
    /// <param name="array">Integer array.</param>
    /// <param name="searchValue">Given search value.</param>
    /// <returns>How many times given number appears in given array.</returns>
    static int ArrayCounter(int[] array, int searchValue)
    {
        int counter = 0;

        for (int element = 0; element < array.Length; element++)
        {
            if (searchValue == array[element])
            {
                counter++;
            }
        }
        return counter;
    }
}

/** Console output:
Enter an integer to search: 5

In array [5, 6, 4, 4, 3, 3, 4, 6, 6, 4, 3, 6, 5, 6, 5, 5, 6, 4, 5, 3]
5 was found 5 times.
Press any key to continue . . .
**/