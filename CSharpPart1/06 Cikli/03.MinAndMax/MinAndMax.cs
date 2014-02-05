// 3. Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them

using System;

class MinAndMax
{
    static void Main()
    {
        Console.Write("How many numbers you will enter? ");
        int numbersN = int.Parse(Console.ReadLine());           // Read N from console
        int maxValue = int.MinValue;
        int minValue = int.MaxValue;
        for (int counter = 1; counter <= numbersN; counter++)   // Loop from 1 to N
        {
            Console.Write("Enter value [{0}]: ", counter); 
            int temp = int.Parse(Console.ReadLine());           // Read numbers from 1 to N on the console 
            if (maxValue < temp)        // Check is maxValue MAXIMUM
            {
                maxValue = temp;    
            }
            if (minValue > temp)        // Check is minValue MINIMUM
            {
                minValue = temp;
            }
        }
        Console.WriteLine("Min value is {0}", minValue);    // Print Min value
        Console.WriteLine("Max value is {0}", maxValue);    // Print Max value
    }
}

/** Console output
How many numbers you will enter? 6
Enter value [1]: 9
Enter value [2]: -5
Enter value [3]: 3
Enter value [4]: 18
Enter value [5]: -7
Enter value [6]: 0
Min value is -7
Max value is 18
Press any key to continue . . .
**/