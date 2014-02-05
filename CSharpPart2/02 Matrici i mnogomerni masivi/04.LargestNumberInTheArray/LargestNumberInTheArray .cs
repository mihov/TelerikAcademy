// 04. Write a program, that reads from the console an array of N integers and an integer K,
// sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

using System;

class LargestNumberInTheArray
{
    static void Main()
    {
        // Reads value for N.
        Console.Write("Enter length of array: ");
        int arrayLength;
        if (!int.TryParse(Console.ReadLine(), out arrayLength))
        {
            // Error message and close application.
            Console.WriteLine("Incorrect value!");
            return;
        }

        // Reads array of N elements.
        int[] integerArray = new int[arrayLength];
        Console.WriteLine("\nEnter values of the array.");
        for (int counter = 0; counter < arrayLength; counter++)
        {
            Console.Write("[{0}] = ", counter);
            if (!int.TryParse(Console.ReadLine(), out integerArray[counter]))
            {
                // Error message and try again
                Console.WriteLine("Incorrect value!");
                counter--;
            }

        }

        // Reads search value
        Console.Write("\nEnter search value: ");
        int searchValue;
        if (!int.TryParse(Console.ReadLine(), out searchValue))
        {
            Console.WriteLine("Incorrect value!");
            return;
        }

        // Prints unsorted array
        Console.WriteLine("\nUnsorted array is:");
        Console.WriteLine(String.Join(", ", integerArray));

        // Sort the array using QuickSort method
        QuickSort(integerArray, 0, arrayLength - 1);

        // Prints sorted array
        Console.WriteLine("\nSorted array is:");
        Console.WriteLine(String.Join(", ", integerArray));

        // Search the value by BinarySearch
        int position = Array.BinarySearch(integerArray, searchValue);

        // Calculate position of Largest number in the array which is less or equal than K
        if (position < 0)
        {
            position = ~position - 1;
        }

        // Prints the result
        Console.WriteLine("\nLargest number in the array which is less or equal than {0} is {1}.", searchValue, integerArray[position]);
    }


    /// <summary>
    /// Quick Sort
    /// </summary>
    /// <param name="integerArray">Integer array.</param>
    /// <param name="left">Left index.</param>
    /// <param name="right">Right index.</param>
    static void QuickSort(int[] integerArray, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(integerArray, left, right);

            // Recursion for left part
            if (pivot > 1)
            {
                QuickSort(integerArray, left, pivot - 1);
            }

            // Recursion for right part 
            if (pivot + 1 < right)
            {
                QuickSort(integerArray, pivot + 1, right);
            }
        }
    }

    /// <summary>
    /// Partitioning integer array
    /// </summary>
    /// <param name="numbers">Integer array</param>
    /// <param name="left">Left index.</param>
    /// <param name="right">Right index.</param>
    /// <returns>Position for partitioning.</returns>
    static int Partition(int[] numbers, int left, int right)
    {
        int pivot = numbers[left];
        while (true)
        {
            while (numbers[left] < pivot)
                left++;

            while (numbers[right] > pivot)
                right--;

            if (left < right)
            {
                int temp = numbers[right];
                numbers[right] = numbers[left];
                numbers[left] = temp;
            }
            else
            {
                return right;
            }
        }
    }
}

/** Console output:
 Enter length of array: 5

Enter values of the array.
[0] = 9
[1] = 7
[2] = 5
[3] = 3
[4] = 1

Enter search value: 6

Unsorted array is:
9, 7, 5, 3, 1

Sorted array is:
1, 3, 5, 7, 9

Largest number in the array which is less or equal than 6 is 5.
Press any key to continue . . .
**/
