// 07. Sorting an array means to arrange its elements in increasing order. 
// Write a program to sort an array. Use the "selection sort" algorithm:
// Find the smallest element, move it at the first position,
// find the smallest from the rest, move it at the second position, etc.

using System;

class SelectionSort
{
    static void Main()
    {
        int lenghtOfArray;
        while (true)
        {
            // Reads lenght of array and try to parse
            Console.Write("Enter the lenght of array: ");
            if (int.TryParse(Console.ReadLine(), out lenghtOfArray))
            {
                break;
            }
            else
            {
                // Error message if fail, and read again.
                Console.WriteLine("Unable to convert. Try again.");
            }
        }

        // Reads the array
        // Declare integer array of lenghtOfArray elements
        int[] unsortedArray = new int[lenghtOfArray];
        Console.WriteLine("Enter {0} integer values.", lenghtOfArray);
        for (int element = 0; element < lenghtOfArray; element++)
        {
            // Reads current element and try it to parse.
            Console.Write("[{0}] => ", (element + 1).ToString().PadLeft(3, ' '));
            if (!int.TryParse(Console.ReadLine(), out unsortedArray[element]))
            {
                // Error message if fail, and read again.
                element--;
                Console.WriteLine("Try again.");
            }
        }
        
        // Print unsorted area
        Console.WriteLine();
        Console.Write("Unsorted array is: ");
        Console.WriteLine(string.Join(", ", unsortedArray));
        
        // Sort array
        // Loop from first to last elemen of array
        for (int elementStart = 0; elementStart < lenghtOfArray; elementStart++)
        {
            int absoluteMinimumElement = unsortedArray[elementStart];
            int absoluteMinimumPosition = elementStart;
            
            // Loop from current search element to the last
            for (int elementSearch = elementStart + 1; elementSearch < lenghtOfArray; elementSearch++)
            {
                // Check is current elelment minimal
                if (absoluteMinimumElement > unsortedArray[elementSearch])
                {
                    // Set values for absoluteMinimumElement and absoluteMinimumPosition
                    absoluteMinimumElement = unsortedArray[elementSearch];
                    absoluteMinimumPosition = elementSearch;
                }
            }
            
            // Exchange current element and MINimal element.
            int temp = unsortedArray[absoluteMinimumPosition];
            unsortedArray[absoluteMinimumPosition] = unsortedArray[elementStart];
            unsortedArray[elementStart] = temp;
        }

        // Print sorted area
        Console.Write("Sorted array is: ");
        Console.WriteLine(string.Join(", ", unsortedArray));
    }
}

/** Console output:
Enter the lenght of array: 5
Enter 5 integer values.
[  1] => 3
[  2] => 9
[  3] => 2
[  4] => 8
[  5] => 5

Unsorted array is: 3, 9, 2, 8, 5
Sorted array is: 2, 3, 5, 8, 9
Press any key to continue . . .
**/