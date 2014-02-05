// 3.9. Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3)
// and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class CircleAndRectangle
{
    static void Main()
    {
        Console.Write("Enter X coordinate of the point P: ");
        float pointX;
        string pointXText = Console.ReadLine();

        if (float.TryParse(pointXText, out pointX))
        {
            Console.Write("Enter Y coordinate of the point P: ");
            float pointY;
            string pointYText = Console.ReadLine();

            if (float.TryParse(pointYText, out pointY))
            {
                // The circle
                float centerX = 1;
                float centerY = 1;
                float radius = 3;

                // The Rectangle
                float rectangleTop = 1;                                       //
                float rectangleLeft = -1;                                     //        top        
                float rectangleWidth = 6;                                     //         ------------------  
                float rectangleHeight = 2;                                    //      l  |                |  
                                                                              //      e  |                |
                float rectangleBottom = rectangleTop - rectangleHeight;       //      f  |                |  
                float rectangleRight = rectangleLeft + rectangleWidth;        //      t  ------------------

                // Is within the circle
                bool withinCircle = radius > (Math.Sqrt(Math.Pow((pointX - centerX), 2) + Math.Pow((pointY - centerY), 2)));

                // Is out of the rectangle
                bool outOfRectangle = (pointX < rectangleLeft) || (pointX > rectangleRight) && (pointY < rectangleBottom) || (pointY > rectangleTop);

                // Print the begining of the secntence
                Console.Write("Point P({0},{1}) is ", pointX, pointY);

                // Print the middle of the sentence about the circle
                if (withinCircle)
                {
                    Console.Write("within the circle K and "); // Point is within the circle
                }
                else
                {
                    Console.Write("out of the circle K and "); // Point is out of the circle
                }

                // Print the end of the sentence about the rectangle
                if (outOfRectangle)
                {
                    Console.WriteLine("out of the rectangle R."); // Point is out of the rectable
                }
                else
                {
                    Console.WriteLine("within the rectangle R."); // Point is within the rectangle
                }
            }
            else Console.WriteLine("Unable to convert '{0}'.", pointYText);
        }
        else Console.WriteLine("Unable to convert '{0}'.", pointXText);
    }
}
/** Console output
Enter X coordinate of the point P: 1
Enter Y coordinate of the point P: 1
Point P(1,1) is within the circle K and within the rectangle R.
Press any key to continue . . .
**/