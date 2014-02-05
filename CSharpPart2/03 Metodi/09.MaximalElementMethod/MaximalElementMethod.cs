// 09. Write a method that return the maximal element in a portion of array of integers starting at given index.
// Using it write another method that sorts an array in ascending / descending order.


using System;

class MaximalElementMethod
{
    static void Main()
    {
        // Define and fill test array
        int[] array = { 1, 2, 3, 4, 5, 4, 3, 2, 1 };
        int begin = 5;

        Console.WriteLine("In array:\n{" + String.Join(", ", array) + "}");
        Console.Write("maximal element from position {0} is ", begin);
        Console.WriteLine(array[MaximalElement(array, begin)]);

        // Sort array ascending and print it 
        SortArray(array, true);
        Console.WriteLine("\nSorted array [ascending]:");
        Console.WriteLine(String.Join(", ", array));

        // Sort array descending and print it
        SortArray(array, false);
        Console.WriteLine("\nSorted array [descending]:");
        Console.WriteLine(String.Join(", ", array));
    }

    static void SortArray(int[] array, bool ascending)
    {
        // Define temporary variables
        int temp;
        int maxPosition;
        for (int counter = 0; counter < array.Length; counter++)
        {
            // Exchange current and maximal element.
            temp = array[counter];
            maxPosition = MaximalElement(array, counter);
            array[counter] = array[maxPosition];
            array[maxPosition] = temp;
        }

        // Reverse the array for ascending
        if (ascending)
        {
            Array.Reverse(array);
        }
    }

    static int MaximalElement(int[] array, int index)
    {
        // Check are begin and end are correct
        if (index >= 0 && index < array.Length)
        {
            // Define max
            int max = array[index];
            int maxIndex = index;

            // Loop for all elements from begin to the end
            for (int counter = index; counter < array.Length; counter++)
            {
                if (array[counter] > max)
                {
                    // If new maximal element reached, save them.
                    max = array[counter];
                    maxIndex = counter;
                }
            }

            // Return the result
            return maxIndex;
        }

        // Return -1 if begin is incorrect
        return -1;
    }
}

/** Console output:
In array:
{1, 2, 3, 4, 5, 4, 3, 2, 1}
maximal element from position 5 is 4

Sorted array [ascending]:
1, 1, 2, 2, 3, 3, 4, 4, 5

Sorted array [descending]:
5, 4, 4, 3, 3, 2, 2, 1, 1
Press any key to continue . . .
**/