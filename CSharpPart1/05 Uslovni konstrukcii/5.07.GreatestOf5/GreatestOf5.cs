// 5.7. Write a program that finds the greatest of given 5 variables.

using System;

class GreatestOf5
{
    static void Main()
    {
        int membersCount = 5; // Set number of variables
        int max = int.MinValue; // Set MAX to be minimum posible
        int temp;

        Console.WriteLine("Enter {0} digits to see the greatest one.", membersCount);
        for (int counter = 1; counter <= membersCount; counter++) // Count from 1 to 5
        {
            Console.Write("[{0}] = ", counter);
            temp = int.Parse(Console.ReadLine());   // Read the current member from console
            if (max < temp)                         // Check who is greatest one
            {
                max = temp;
            }
        }

        // Print resulr on the console
        Console.WriteLine("The greatest is {0}", max);
    }
}

/** Console output
Enter 5 digits to see the greatest one.
[1] = 66
[2] = 25
[3] = 49
[4] = 8
[5] = -15
The greatest is 66
Press any key to continue . . . 
 **/
