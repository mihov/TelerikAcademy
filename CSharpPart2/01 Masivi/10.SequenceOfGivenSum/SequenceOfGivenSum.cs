// 10. Write a program that finds in given array of integers a sequence of given sum S (if present).
// Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11 ==>> {4, 2, 5}

using System;
using System.Collections.Generic;

class SequenceOfGivenSum
{
    static void Main()
    {
        Console.Write("Enter some integer sequence. Elements separated by comma.\nSeqence: ");
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

        // Reads value for sum S
        int theSum;
        while (true)
        {
            Console.Write("Enter the Sum you want to see: ");
            
            // Read and try to parse
            if (int.TryParse(Console.ReadLine(), out theSum))
            {
                break;  
            }
            Console.WriteLine("Unable to conver, Try again.");
        }

        // Loop for all elements of seqence
        for (int element = 0; element < intSequence.Count; element++)
        {
            // Define temporary sum
            int tempSum = 0;
            
            // Loop from current element to the last one
            for (int elementSearch = element; elementSearch < intSequence.Count; elementSearch++)
            {
                // Calculate temp sum
                tempSum += intSequence[elementSearch];
                
                // Check temp and given sum
                if (tempSum == theSum)
                {
                    // Print the sub array 
                    Console.Write("{");
                    for (int subElement = element; subElement <= elementSearch; subElement++)
                    {
                        Console.Write(intSequence[subElement]);
                        if (subElement < elementSearch)
                        {
                            Console.Write(", ");
                        }
                        else
                        {
                            Console.WriteLine("}");
                        }
                    }
                }
            }
        }
    }
}

/** Concole output:
Enter some integer sequence. Elements separated by comma.
Seqence: 4, 3, 1, 4, 2, 5, 8
Enter the Sum you want to see: 12
{4, 3, 1, 4}
{1, 4, 2, 5}
Press any key to continue . . .
 * 
 * 
Enter some integer sequence. Elements separated by comma.
Seqence: 4, 3, 1, 4, 2, 5, 8
Enter the Sum you want to see: 11
{4, 2, 5}
Press any key to continue . . .
**/