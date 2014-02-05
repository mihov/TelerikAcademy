// 4.2. Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;
using System.Globalization;

class CirclePerimeter
{
    static void Main()
    {
        // Read the radius from console
        Console.Write("Enter radius \"r\" of circle to see perimeter and area: ");
        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // Calculate the perimeter
        double perimeter = 2 * Math.PI * radius;

        // Calculate the area
        double area = Math.PI * radius * radius;

        // Print the recult on the console
        Console.WriteLine("\nCircle with radius = {0} \nhas perimeter {1:F2} and area {2:F2}.", radius, perimeter, area);
    }
}

/** Console output:
Enter radius "r" of circle to see perimeter and area: 10

Circle with radius = 10
has perimeter 62,83 and area 314,16.
Press any key to continue . . .
 **/
