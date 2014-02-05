// 4.10. Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

class Sum
{
    static void Main()
    {
        double previousMember = 1.0;                                // Define previos member
        double currentMember;                                       // Declare current member
        int memberCount = 2;                                        // Devine counter
        double difference;                                          // Declare differense
        do
        {
            if (memberCount % 2 == 0)                               // Check for odd or even
            {
                currentMember = previousMember + 1.0 / memberCount; // Calculate current member and sum with previous
            }
            else
            {
                currentMember = previousMember - 1.0 / memberCount;
            }
            difference = Math.Abs(previousMember - currentMember);  // Calculate the difference
            previousMember = currentMember;                         // Assign current member as previous                       
            memberCount++;                                          // Increment counter
        } while (difference > 0.001);                               // Check the difference
        
        // Print result on the console
        Console.WriteLine("The sum is {0}.", currentMember);
        Console.WriteLine("The sum is calculated from {0} members.", memberCount);
    }
}

/** Console output:
The sum is 1.30735256944018.
The sum is calculated from 1001 members.
Press any key to continue . . .
**/
