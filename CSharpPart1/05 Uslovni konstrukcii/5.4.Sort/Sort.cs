// 5.4. Sort 3 real values in descending order using nested if statements.

using System;

class Sort
{
    static void Main()
    {
        // Read values from console
        Console.WriteLine("Enter three numbers, to see them sorted.");
        Console.Write("[1] = ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("[2] = ");
        int second = int.Parse(Console.ReadLine());
        Console.Write("[3] = ");
        int third = int.Parse(Console.ReadLine());

        // Declare and set some variables
        int smallest = 0;
        int middle = 0;
        int largest = 0;

        if ((first > second) && (first > third)) // if first is bigger
        {
            largest = first;

            if (second > third)
            {
                middle = second;
                smallest = third;
            }
            else
            {
                middle = third;
                smallest = second;
            }
        }
        else if ((second > first) && (second > third)) // if second is bigger
        {
            largest = second;
            if (first > third)
            {
                middle = first;
                smallest = third;
            }
            else
            {
                middle = third;
                smallest = first;
            }
        }
        else if ((third > first) && (third > second)) // if third is bigger
        {
            largest = third;
            if (first > second)
            {
                middle = first;
                smallest = second;
            }
            else
            {
                middle = second;
                smallest = first;
            }
        }
        
        // Print result on the console
        Console.WriteLine("Sorted descending list of {0} {1} {2} is:", first, second, third);
        Console.WriteLine("{0} {1} {2}", largest, smallest, middle);
    }
}

/** Console Output:
Enter three numbers, to see them sorted.
[1] = 9
[2] = 7
[3] = 5
Sorted descending list of 9 7 5 is:
9 5 7
Press any key to continue . . .
 * 
 * 
 Enter three numbers, to see them sorted.
[1] = 3
[2] = 5
[3] = 7
Sorted descending list of 3 5 7 is:
7 3 5
Press any key to continue . . .
 **/
