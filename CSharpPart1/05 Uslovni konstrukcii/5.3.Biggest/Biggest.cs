// 5.Write a program that finds the biggest of three integers using nested if statements.

using System;

class Biggest
{
    static void Main()
    {
        // Read values from console
        Console.WriteLine("Enter three numbers, to see the maximum of them.");
        Console.Write("[1] = ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("[2] = ");
        int second = int.Parse(Console.ReadLine());
        Console.Write("[3] = ");
        int third = int.Parse(Console.ReadLine());


        int max = first; // Let the first is max

        if (second > max)// Let the second is max
        {
            max = second;
        }

        if (third > max)// Let the thirdt is max
        {
            max = third;
        }

        // Print result on the console
        Console.WriteLine("The max value is {0}", max);
    }
}

/** Console output:
Enter three numbers, to see the maximum of them.
[1] = 9
[2] = 10
[3] = 8
The max value is 10
Press any key to continue . . .

**/