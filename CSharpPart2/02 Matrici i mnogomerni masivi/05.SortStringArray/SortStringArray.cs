// 05. You are given an array of strings.
// Write a method that sorts the array by the length of its elements
// (the number of characters composing them).


using System;

class SortStringArray
{
    static void Main()
    {
        // Define and fill string array.
        string[] stringArray = { "Ford", "GMC", "Harvester", "Jeep", "Lincoln", "Honda", "Chevrolett" };

        // Print unsorted array.
        Console.WriteLine("Unsorted:");
        Console.WriteLine(new string('-', 10));
        foreach (string item in stringArray)
        {
            Console.WriteLine(item);
        }

        // Using of Quick Sort method
        QuickSort(stringArray, 0, stringArray.Length - 1);

        // Print sorted array.
        Console.WriteLine("\nSorted:");
        Console.WriteLine(new string('-', 10));
        foreach (string item in stringArray)
        {
            Console.WriteLine(item);
        }

    }

    static void QuickSort(String[] elements, int left, int right)
    {
        int i = left;
        int j = right;

        // Define and get the pivot
        int pivot = elements[(left + right) / 2].Length;

        while (i <= j)
        {
            // For left
            while (elements[i].Length < pivot)
            {
                i++;
            }
            
            // For right
            while (elements[j].Length > pivot)
            {
                j--;
            }
            if (i <= j)
            {
                // Swap elements
                String temp = elements[i];
                elements[i] = elements[j];
                elements[j] = temp;

                i++;
                j--;
            }
        }
        if (left < j)
        {
            // Call it self for left part
            QuickSort(elements, left, j);
        }
        if (i < right)
        {
            // Cal it self for right part
            QuickSort(elements, i, right);
        }
    }
}

/** Console output:
Unsorted:
----------
Ford
GMC
Harvester
Jeep
Lincoln
Honda
Chevrolett

Sorted:
----------
GMC
Jeep
Ford
Honda
Lincoln
Harvester
Chevrolett
Press any key to continue . . .
 **/
