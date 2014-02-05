// 08. Write a program that finds the sequence of maximal sum in given array. Example:
//	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8} => {2, -1, 6, 4}
//	Can you do it with only one loop (with single scan through the elements of the array)?
//  This link helped me a lot http://en.wikipedia.org/wiki/Maximum_subarray_problem

using System;

class SequenceOfMaximalSum
{
    static void Main()
    {
        // Declare and set values for the seqence
        int[] seqence = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

        int maximalSum = seqence[0];
        int tempMaximalSum = seqence[0];

        // Variables to track the position of the subarray
        int startPoint = 0;
        int beginTempPoint = 0;
        int endPoint = 0;

        // Find sequence by looping through
        for (int i = 1; i < seqence.Length; i++)
        {
            // calculate Temp Maximal Sum
            if (tempMaximalSum < 0)
            {
                tempMaximalSum = seqence[i];
                beginTempPoint = i;
            }
            else
            {
                tempMaximalSum += seqence[i];
            }

            // calculate Maximal Sum
            if (tempMaximalSum >= maximalSum)
            {
                maximalSum = tempMaximalSum;

                startPoint = beginTempPoint;
                endPoint = i;
            }
        }
        
        // Print the result
        // Print the seqence
        Console.Write('{' + string.Join(", ", seqence) + "} => {");

        // Print maximal sum seqence
        for (int i = startPoint; i <= endPoint; i++)
        {
            Console.Write(seqence[i]);
            if (i < endPoint)
            {
                Console.Write(", ");
            }
            else
            {
                Console.WriteLine("}");
            }
        }
        
        // Print the maximal sum
        Console.WriteLine("Maximal sum is {0}.", maximalSum);
    }
}

/** Console output:
{2, 3, -6, -1, 2, -1, 6, 4, -8, 8} => {2, -1, 6, 4, -8, 8}
Maximal sum is 11.
Press any key to continue . . .
**/