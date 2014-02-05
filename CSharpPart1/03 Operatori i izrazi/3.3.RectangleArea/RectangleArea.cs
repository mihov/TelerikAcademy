// 3.3. Write an expression that calculates rectangle’s area by given width and height.

using System;

class RectangleArea
{
    static void Main()
    {
        // Print some info text
        Console.WriteLine("Rectangle area calculator.\nEnter value for:");

        // Declare the integer number
        float width, height;

        // Read the width from console
        Console.Write("width : ");
        string value = Console.ReadLine();

        // Try to convert
        bool result = float.TryParse(value, out width);

        if (result)
        {
            // Read the height from console
            Console.Write("height: ");
            value = Console.ReadLine();

            // Try to convert
            result = float.TryParse(value, out height);

            if (result)
            {
                Console.WriteLine("\nThe area of rectangle with \nwidth = {0} and height = {1} is {2}.", width, height, (width * height)); // Calc the area
            }
            else
            {
                Console.WriteLine("\nAttempted conversion of '{0}' failed.", value); // Convert failed
            }
        }
        else
        {
            Console.WriteLine("\nAttempted conversion of '{0}' failed.", value); // Convert failed
        }
    }
}
/** Console output:
Rectangle area calculator.
Enter value for:
width : 5
height: 6

The area of rectangle with
width = 5 and height = 6 is 30.
Press any key to continue . . .
 **/