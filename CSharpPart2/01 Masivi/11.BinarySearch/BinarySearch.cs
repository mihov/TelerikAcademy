// 11. Write a program that finds the index of given element in a sorted array of integers
// by using the binary search algorithm (find it in Wikipedia).


using System;
using System.Collections.Generic;

class BinarySearch
{
    // Method IsArraySorted
    static bool IsArraySorted(List<int> checkedArray)
    {
        // Loop from first to last element
        for (int element = 0; element < checkedArray.Count - 1; element++)
        {
            // Is current element lower than next one?
            if (checkedArray[element] > checkedArray[element + 1])
            {
                return false;
            }
        }
        return true;
    }

    // Method BinarySearch
    static int ArrayBinarySearch(List<int> array, int value)
    {
        int low = 0;
        int high = array.Count - 1;
        int midpoint = 0;

        while (low <= high)
        {
            midpoint = low + (high - low) / 2;

            // check to see if value is equal to item in array
            if (value == array[midpoint])
            {
                return midpoint;
            }
            else if (value < array[midpoint])
                high = midpoint - 1;
            else
                low = midpoint + 1;
        }

        // item was not found
        return -1;
    }

    static void Main()
    {
        Console.Write("Enter sorted integer sequence. Elements separated by comma.\nSeqence: ");
        // Read the seuence as string
        string sequenceAsString = Console.ReadLine();

        // Declare new integer seqence
        List<int> intSequence = new List<int>();
        int tempIntValue;
        string tempStrValue = null;
        sequenceAsString += ','; // this is secret, hi hi
        sequenceAsString.Replace(" ", ""); // this remove spases
        sequenceAsString.Replace(",,", ","); // this change ,,  to , 

        // Convert the string seqence to int seqence
        // Loop from 0 to lenght of string seqence
        for (int element = 0; element < sequenceAsString.Length; element++)
        {
            if ((sequenceAsString[element] == ',') && (tempStrValue != null))
            {
                // Try to convert string to int
                if (int.TryParse(tempStrValue, out tempIntValue))
                {
                    // Add new value to the integer sequence
                    intSequence.Add(tempIntValue);
                    tempStrValue = null;
                }
                else
                {
                    // Report "Unable to convert" if Parse fail
                    Console.WriteLine("Unable to convert {0} to integer!", tempStrValue);
                    break;
                }
            }
            else tempStrValue += sequenceAsString[element]; // This is for elements with more than one digits
        }

        // Uses of method IsArraySorted
        if (!IsArraySorted(intSequence))
        {
            // Print error message and close the application
            Console.WriteLine("The seqence is not sorted!");
            return;
        }

        // Reads value for sum S
        int searchedElement;
        while (true)
        {
            Console.Write("Enter the value of searched element: ");

            // Read and try to parse
            if (int.TryParse(Console.ReadLine(), out searchedElement))
            {
                break;
            }
            Console.WriteLine("Unable to conver, Try again.");
        }

        // Uses of method ArrayBinarySearch
        int foundAtPosition = ArrayBinarySearch(intSequence, searchedElement);
        
        // Checks the result and print the answer.
        if (foundAtPosition >= 0)
        {
            // Element found.
            Console.WriteLine("Element {0} found at position {1}.", searchedElement, foundAtPosition);
        }
        else
        {
            // Element did not find.
            Console.WriteLine("Element {0} did not find.", searchedElement);
        }

    }
}
