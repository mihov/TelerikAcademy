// 04. Write a program that finds the maximal sequence of equal elements in an array.
//	   Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} => {2, 2, 2}.

using System;

class MaximalSequence
{
    static void Main()
    {
        // Print some information
        Console.Write("Enter some sequence: ");

        // Read the char array.         !!!String is a char array!!! 
        string theSequence = Console.ReadLine();

        // Current char = first element of seqence
        char currentChar = theSequence[0];

        // Keep which char is maximum
        char? maxChar = null;

        // Maximum for whole sequence
        int sequenceMax = 0;

        // Maximum for current sequence
        int currentMax = 1;

        // Loop from 0 to length of the Sequence
        for (int element = 1; element < theSequence.Length; element++)
        {
            if (currentChar == theSequence[element])
            {
                // Increase local maximum only if currentChar = current element of the Sequence
                currentMax++;
            }
            else
            {
                if (currentMax > sequenceMax)
                {
                    // Set new value for maxChar
                    maxChar = currentChar;

                    // Sequence maximum = local maximum
                    sequenceMax = currentMax;
                }

                // currentChar = current element of the Sequence
                currentChar = theSequence[element];

                // Set local maximum to 1
                currentMax = 1;
            }
            // Check the sequence of the last element
            if ((element == theSequence.Length - 1) && (currentMax > sequenceMax))
            {
                // Set maxChar with last sequence char
                maxChar = currentChar;

                // Set sequenceMax to be as maximumm of last secuence
                sequenceMax = currentMax;
            }
        }

        // Print the result
        Console.WriteLine("Max seqence of {0} is {1}.", theSequence, new String((char)maxChar, sequenceMax));
    }
}
/** Console output:
Enter some sequence: 1223334444333221
Max seqence of 1223334444333221 is 4444.
Press any key to continue . . .
 * 
 * 
 * 
Enter some sequence: abbcccdddd
Max seqence of abbcccdddd is dddd.
Press any key to continue . . .
**/