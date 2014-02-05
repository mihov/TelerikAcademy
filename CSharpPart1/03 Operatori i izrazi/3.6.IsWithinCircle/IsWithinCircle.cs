// 3.6. Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;

class IsWithinCircle
{
    static void Main()
    {
        // Read variables X and Y of the given point
        Console.Write("Enter coordinates of point:\nX = ");
        int pointX = int.Parse(Console.ReadLine());
        Console.Write("Y = ");
        int pointY = int.Parse(Console.ReadLine());

        // Declare variable of the circle
        int circleRadius = 5;

        // a²+b²=c²  -> pointX² + pointY² = circleRadius²
        if ((pointX * pointX + pointY * pointY) <= (circleRadius * circleRadius))
        {
            Console.WriteLine("Point {0}:{1} is within the circle K(O, 5).", pointX, pointY);
        }
        else
        {
            Console.WriteLine("Point {0}:{1} is out of the circle K(O, 5).", pointX, pointY);
        }
    }
}
/** Console output
Enter coordinates of point:
X = 2
Y = 3
Point 2:3 is within the circle K(O, 5).
Press any key to continue . . .
**/