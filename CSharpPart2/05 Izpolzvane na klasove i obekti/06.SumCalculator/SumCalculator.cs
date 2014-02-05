// 06. You are given a sequence of positive integer values written into a string, separated by spaces.
// Write a function that reads these values from given string and calculates their sum.
// Example:     		string = "43 68 9 23 318" --> result = 461

using System;
using System.Collections.Generic;

class SumCalculator
{
    static void Main()
    {
        Console.WriteLine("Enter a sequence of positive integer values separated by spaces.");
        Console.Write("> ");

        // Reads the integer values written into a string
        string test = Console.ReadLine();
        Console.Write("You entered: ");

        // Prints integer values
        Console.WriteLine(String.Join(", ", StringToList(test, ' ')));

        // Print the sum of them
        Console.WriteLine("Their sum is: {0}.", Sumator(StringToList(test, ' ')));


    }

    // Calculate the sum of List elements
    static int Sumator(List<int> intList)
    {
        int result = 0;

        foreach (int item in intList)
        {
            result += item;
        }

        return result;
    }

    // Convert given string to list of integer elements, by given separator
    static List<int> StringToList(string intValues, char separator)
    {
        List<int> result = new List<int>();


        intValues = intValues.Trim() + separator;


        string currentValue = string.Empty;

        // Loop for all list elements
        for (int counter = 0; counter < intValues.Length; counter++)
        {

            // 
            if (intValues[counter] != separator)
            {
                // Create current value
                currentValue += intValues[counter];
            }
            else
            {
                // Put current value to list
                result.Add(int.Parse(currentValue));
                currentValue = string.Empty;
            }
        }

        // Return the result
        return result;
    }
}

/** Console output:
Enter a sequence of positive integer values separated by spaces.
> 10 20 30 40
You entered: 10, 20, 30, 40
Their sum is: 100.
Press any key to continue . . .
**/