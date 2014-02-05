// 3.8. Write an expression that calculates trapezoid's area by given sides a and b and height h. 

using System;

class TrapezoidArea
{
    static void Main()
    {
        // Read the sides values
        Console.Write("Enter length of side a of trapezoid  : ");
        float sideA = float.Parse(Console.ReadLine());
        Console.Write("Enter length of side b of trapezoid  : ");
        float sideB = float.Parse(Console.ReadLine());

        // Read the height
        Console.Write("Enter height of trapezoid h          : ");
        float height = float.Parse(Console.ReadLine());

        // Calculate the area
        float area = ((sideA + sideB) / 2) * height;

        // Print the result on the console
        Console.WriteLine("\nThe trapezoid's area is {0}.", area);
    }
}

/** Console output:
Enter length of side a of trapezoid  : 5
Enter length of side b of trapezoid  : 5
Enter height of trapezoid h          : 3

The trapezoid's area is 15.
Press any key to continue . . .
**/