// 14. Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

using System;

class QuickSort
{
    static void Main()
    {
        // Declage and define array of strings. US car brands.
        string[] unsortedArray =    {
                                    "Saleen", "Buick", "Cadillac", "Tesla", "Dodge", "Ram", "Falcon", 
                                    "Ford", "GMC", "Harvester", "Jeep", "Lincoln", "Chevrolet", "Navistar", "Fisker", 
                                    "Callaway", "Panoz", "Chrysler", "Mosler", "E-Z-GO", "Hennessey" 
                                    };

        // Declare sorted aray and Clone values from unsorted array
        string[] sortedArray = (string[])unsortedArray.Clone();

        // Apply Quicksort
        Quicksort(sortedArray, 0, sortedArray.Length - 1);

        // Prints both arrays.
        Console.WriteLine("{0}{1}", "Unsorted".PadRight(30, ' '), "Sorted");
        Console.WriteLine(new string('=', 40));
        for (int element = 0; element < sortedArray.Length; element++)
        {
            Console.WriteLine("{0}{1}", unsortedArray[element].PadRight(30, ' '), sortedArray[element]);
        }

    }

    // Method Quick Sort
    public static void Quicksort(IComparable[] elements, int left, int right)
    {
        int i = left;
        int j = right;

        IComparable pivot = elements[(left + right) / 2];

        while (i <= j)
        {
            while (elements[i].CompareTo(pivot) < 0)
            {
                i++;
            }
            while (elements[j].CompareTo(pivot) > 0)
            {
                j--;
            }
            if (i <= j)
            {
                // Swap elements
                IComparable temp = elements[i];
                elements[i] = elements[j];
                elements[j] = temp;

                i++;
                j--;
            }
        }
        if (left < j)
        {
            // Call it self for left part
            Quicksort(elements, left, j);
        }
        if (i < right)
        {
            // Cal it self for right part
            Quicksort(elements, i, right);
        }
    }
}

/** Console Output:
Unsorted                      Sorted
========================================
Saleen                        Buick
Buick                         Cadillac
Cadillac                      Callaway
Tesla                         Chevrolet
Dodge                         Chrysler
Ram                           Dodge
Falcon                        E-Z-GO
Ford                          Falcon
GMC                           Fisker
Harvester                     Ford
Jeep                          GMC
Lincoln                       Harvester
Chevrolet                     Hennessey
Navistar                      Jeep
Fisker                        Lincoln
Callaway                      Mosler
Panoz                         Navistar
Chrysler                      Panoz
Mosler                        Ram
E-Z-GO                        Saleen
Hennessey                     Tesla
Press any key to continue . . .
**/
