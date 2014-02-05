// 02. Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class RandomValues
{
    static void Main()
    {
        // DEfine instanse from class Random
        Random randomGenerator = new Random();

        Console.WriteLine("Print 10 random values in the range [100, 200].");

        // Loop for 10 values
        for (int counter = 1; counter <= 10; counter++)
        {
            // Call "Next" with proper value
            Console.WriteLine("[{0}] --> {1}", counter.ToString().PadLeft(2, ' '), randomGenerator.Next(100, 201));
        }
    }
}

/** Console output: 
Print 10 random values in the range [100, 200].
[ 1] --> 107
[ 2] --> 143
[ 3] --> 168
[ 4] --> 177
[ 5] --> 153
[ 6] --> 161
[ 7] --> 140
[ 8] --> 124
[ 9] --> 177
[10] --> 177
Press any key to continue . . .
**/