// 05. Write a method that checks if the element at given position in given array of integers
// is bigger than its two neighbors (when such exist).

using System;

class BiggerThanNeighborsMethod
{
    static void Main()
    {
        // Define and fill test array
        int[] testArray = { 1, 2, 3, 4, 5, 4, 3, 2, 1 };
        
        // Prints defined test array
        Console.WriteLine("In array [{0}]", String.Join(", ", testArray));

        // Loop for all elemens from array
        for (int counter = 0; counter < testArray.Length; counter++)
        {
            // Call method
            if (BiggerThanNeighbors(testArray, counter))
            {
                // Prints result only if current element is bigger than its neighbors
                Console.WriteLine("Element {0} at position {1} is bigger than its neighbors.", testArray[counter], counter);
            }
        }
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
Element 5 at position 4 is bigger than its neighbors.
Press any key to continue . . .
 **/
