// 13. Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).

using System;
using System.Collections.Generic;

class MergeSort
{
    static void Main()
    {
        Console.Write("How many numbers do you want to sort? ");

        // Declare some random  
        Random rnd = new Random();

        // Reads numbers of random elements
        int numbersCount = int.Parse(Console.ReadLine());

        // Declare Collection to hold random elements
        List<int> unsortedList = new List<int>();

        for (int count = 0; count < numbersCount; count++)
        {
            // Fill List with random values
            unsortedList.Add(rnd.Next(99));
        }

        // Prints unsorted list
        Console.Write("Unsorted array:\n-> ");
        PrintArray(unsortedList);

        // Declare Collection to hold random elements        
        List<int> sortedList = MergeSorter.Sort(unsortedList);

        // Prints unsorted list
        Console.Write("Sorted array:\n-> ");
        PrintArray(sortedList);
    }

    // Method prin array
    static void PrintArray<T>(List<T> list)
    {
        Console.WriteLine(string.Join(", ", list));
    }

    // Define Class MergeSorter
    static class MergeSorter
    {
        // Method Sort
        public static List<T> Sort<T>(List<T> list) where T : IComparable
        {
            // If contains only 1 element is in the list, list is sorted. End of recursion for Sort. 
            if (list.Count <= 1)
            {
                return list;
            }

            // Divide the list to left and right halves.
            List<T> left = list.GetRange(0, list.Count / 2);
            List<T> right = list.GetRange(left.Count, list.Count - left.Count);

            // Call it self Sort, for left and right halves and Merge them after that.
            return Merge(Sort(left), Sort(right));
        }

        // Method Merge
        static List<T> Merge<T>(List<T> left, List<T> right) where T : IComparable
        {
            // Declare result collection
            List<T> result = new List<T>();
            while (left.Count > 0 && right.Count > 0)
            {
                if (left[0].CompareTo(right[0]) <= 0)
                {
                    // Add first element from left to result
                    result.Add(left[0]);

                    // Remore first element from left
                    left.RemoveAt(0);
                }
                else
                {
                    // Add first element from right to result
                    result.Add(right[0]);

                    // Remore first element from right
                    right.RemoveAt(0);
                }
            }
            result.AddRange(left);
            result.AddRange(right);
            return result;
        }
    }
}

/** Console output:
How many numbers do you want to sort? 15
Unsorted array:
-> 84, 0, 78, 89, 92, 56, 26, 79, 96, 37, 32, 19, 7, 19, 14
Sorted array:
-> 0, 7, 14, 19, 19, 26, 32, 37, 56, 78, 79, 84, 89, 92, 96
Press any key to continue . . .
**/