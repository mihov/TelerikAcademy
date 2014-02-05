// 09.  Write a program that finds the most frequent number in an array. Example:
//	    {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} => 4 (5 times)

using System;
using System.Collections.Generic;

class MostFrequentNumber
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

        // Print the sequence
        Console.Write("{" + String.Join(", ", intSequence) + "} => ");

        // Declare global max value and count
        int maxCount = 0;
        int? maxValue = null;

        // Loop from first to last element
        for (int element = 0; element < intSequence.Count; element++)
        {
            // Keep current element count
            int tempCount = 0;

            // Loop from first to last element
            for (int elementSearch = 0; elementSearch < intSequence.Count; elementSearch++)
            {
                // Check is current element repeats increase it count.
                if (intSequence[element] == intSequence[elementSearch])
                {
                    tempCount++;
                }
            }
            // Check is current count bigger than global max count and get this maximal value
            if (tempCount > maxCount)
            {
                maxCount = tempCount;
                maxValue = intSequence[element];
            }
        }
        // Print the result;
        Console.WriteLine("{0} ({1} times.)", maxValue, maxCount);
    }
}
/** Console output:
Enter some integer sequence. Elements separated by comma.
Seqence: 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3
{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} => 4 (5 times.)
Press any key to continue . . .
**/
