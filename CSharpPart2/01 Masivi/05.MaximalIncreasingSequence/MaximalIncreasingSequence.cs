// 05. Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4} => {2, 3, 4}.

using System;
using System.Collections.Generic;

class MaximalIncreasingSequence
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

        // Print the begining of the answer
        Console.Write("\nThe maximal increasing sequence in an array: \n{");
        for (int element = 0; element < intSequence.Count; element++)
        {
            Console.Write(intSequence[element]);
            if (element != intSequence.Count - 1)
            {
                Console.Write(",");
            }
        }
        Console.Write("}\nis\n{");


        // Discover the seqence
        // Set some Start values
        int maxBegin = int.MinValue;
        int maxLenght = 0;
        int currentBegin = int.MinValue;
        int currentElement = int.MinValue;
        int currentLenght = 0;

        // Loop for elements of the integer sequence
        for (int element = 0; element < intSequence.Count; element++)
        {
            // Check for increasing
            if ((currentElement + 1) == intSequence[element])
            {
                currentLenght++;
                currentElement = intSequence[element];
            }
            else
            {
                // If current element is not from increasing seqence
                currentLenght = 1;
                currentBegin = intSequence[element];
                currentElement = currentBegin;
            }

            // If current sequence is longer than last one
            if (maxLenght < currentLenght)
            {
                maxLenght = currentLenght;
                maxBegin = currentBegin;
            }
        }

        // Print the end of the result
        for (int element = maxBegin; element <= maxBegin+maxLenght-1; element++)
        {
            Console.Write(element);
            if (element != maxBegin+maxLenght-1)
            {
                Console.Write(",");
            }
        }
        Console.WriteLine("}");


    }
}
/** Console output:
Enter some integer sequence. Elements separated by comma.
Seqence: 1,2,3,5,6,7,8,10,11,12,10,10

The maximal increasing sequence in an array:
{1,2,3,5,6,7,8,10,11,12,10,10}
is
{5,6,7,8}
Press any key to continue . . .

**/