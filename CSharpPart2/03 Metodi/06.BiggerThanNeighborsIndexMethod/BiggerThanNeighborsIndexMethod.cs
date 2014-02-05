// 06. Write a method that returns the index of the first element in array that is bigger than its neighbors,
// or -1, if there’s no such element.  Use the method from the previous exercise.


using System;

class BiggerThanNeighborsIndexMethod
{
    static void Main()
    {
        // Define and fill two test arrays
        int[] testArray1 = { 1, 2, 3, 4, 5, 4, 3, 2, 1 };
        int[] testArray2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // Prints defined test array1
        Console.WriteLine("In array [{0}]", String.Join(", ", testArray1));

        Console.Write("The index of the first element in array that is bigger than its neighbors is: ");

        // Prints the result to the calling method.
        Console.WriteLine(BiggerThanNeighborsIndex(testArray1));

        // Prints defined test array2
        Console.WriteLine("\nIn array [{0}]", String.Join(", ", testArray2));

        Console.Write("The index of the first element in array that is bigger than its neighbors is: ");

        // Prints the result to the calling method.
        Console.WriteLine(BiggerThanNeighborsIndex(testArray2));
    }

    /// <summary>
    /// Returns the index of the first element in array that is bigger than its neighbors
    /// </summary>
    /// <param name="array">Integer array.</param>
    /// <returns>Position of element or -1 if there’s no such element</returns>
    static int BiggerThanNeighborsIndex(int[] array)
    {
        for (int counter = 0; counter < array.Length; counter++)
        {
            // Call method
            if (BiggerThanNeighbors(array, counter))
            {
                return counter;
            }
        }
        return -1;
    }

    /// <summary>
    /// Return is the element of integer array is bigger than its two neighbors
    /// </summary>
    /// <param name="array">Integer array</param>
    /// <param name="position">Position of element</param>
    /// <returns>Is element of integer array is bigger than its two neighbors</returns>
    static bool BiggerThanNeighbors(int[] array, int position)
    {
        // Check is "position" in array. 
        if (position > 0 && position < array.Length - 1)
        {
            // Check is the element is bigger than its two neighbors
            if (array[position] > array[position - 1] && array[position] > array[position + 1])
            {
                // Return the element is bigger than its two neighbors
                return true;
            }
        }

        // Return thr element is not bigger than its two neighbors or neighbos do not exist.
        return false;
    }
}

/** Console output:
In array [1, 2, 3, 4, 5, 4, 3, 2, 1]
The index of the first element in array that is bigger than its neighbors is: 4

In array [1, 2, 3, 4, 5, 6, 7, 8, 9]
The index of the first element in array that is bigger than its neighbors is: -1

Press any key to continue . . .
 **/
