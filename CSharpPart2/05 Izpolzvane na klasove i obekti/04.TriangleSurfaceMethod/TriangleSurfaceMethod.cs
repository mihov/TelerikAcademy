// 04. Write methods that calculate the surface of a triangle by given:
// Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

using System;

class TriangleSurfaceMethod
{
    static void Main()
    {
        while (true)
        {
            // Prints menu
            PrintMenu();

            // Reads key
            switch (GetAnswer())
            {
                // Dialogs and results
                case 1:
                    SideAndAltitude();
                    break;
                case 2:
                    ThreeSides();
                    break;
                case 3:
                    TwoSidesAndAngle();
                    break;
                case 4:
                    // Close program
                    Exit();
                    return;

                default:
                    ErrorMessage();
                    break;
            }
            Console.ReadKey();
        }
    }

    // Calculate the Surface by side and altitude
    static double TriangleSurface(double side, double altitude)
    {
        return side * altitude / 2.0;
    }

    // Calculate the Surface by Three sides
    static double TriangleSurface(double sideA, double sideB, double sideC)
    {

        return (sideA + sideB + sideC) / 2.0;
    }

    //  Calculate the Surface by Two sides and an angle between them.
    static double TriangleSurface(double sideA, double sideB, int angle)
    {

        return sideA * sideB / 2.0 * Math.Sin(angle * Math.PI / 180.0);
    }

    // Print menu to console
    static void PrintMenu()
    {
        Console.Clear();
        string menu = @"
===============================================
|         Triangle Surface Calculator         |
===============================================
|   1 -> Side and an altitude.                |
|   2 -> Three sides.                         |
|   3 -> Two sides and an angle between them. |
|---------------------------------------------|
|   4 -> Exit.                                |
===============================================";
        Console.Write(menu);
    }

    // Read key and return answer
    static int GetAnswer()
    {
        // Reads pressed key
        ConsoleKeyInfo pressetKey = Console.ReadKey();
        Console.WriteLine();
        switch (pressetKey.KeyChar)
        {
            case '1':
            case '2':
            case '3':
            case '4':
                return int.Parse(pressetKey.KeyChar.ToString());
            default:
                return 0;
        }
    }

    // Prints dialog, calculate and print the result.
    static void SideAndAltitude()
    {
        Console.Write("|   Enter length of the side:                 |");
        double side;
        Console.SetCursorPosition(30, 10);
        if (double.TryParse(Console.ReadLine(), out side))
        {
            Console.WriteLine("|   Enter length of the altitude:             |");
            Console.SetCursorPosition(34, 11);
            double altitude;
            if (double.TryParse(Console.ReadLine(), out altitude))
            {
                SingleLine();
                Console.WriteLine("|   Surface is {0}", TriangleSurface(side, altitude));
                Console.SetCursorPosition(46, 13);
                Console.WriteLine("|");
                DoubleLine();
                return;
            }
        }
        Console.WriteLine("|   Unable to parse!                          |");
        DoubleLine();
    }

    // Prints dialog, calculate and print the result.
    static void ThreeSides()
    {
        Console.Write("|   Enter length of the side A:               |");
        double sideA;
        Console.SetCursorPosition(32, 10);
        if (double.TryParse(Console.ReadLine(), out sideA))
        {
            Console.Write("|   Enter length of the side B:               |");
            Console.SetCursorPosition(32, 11);
            double sideB;
            if (double.TryParse(Console.ReadLine(), out sideB))
            {
                Console.Write("|   Enter length of the side C:               |");
                Console.SetCursorPosition(32, 12);
                double sideC;
                if (double.TryParse(Console.ReadLine(), out sideC))
                {
                    SingleLine();
                    Console.WriteLine("|   Surface is {0}", TriangleSurface(sideA, sideB, sideC));
                    Console.SetCursorPosition(46, 14);
                    Console.WriteLine("|");
                    DoubleLine();
                    return;
                }
            }
            Console.WriteLine("|   Unable to parse!                          |");
            DoubleLine();
        }
    }

    // Prints dialog, calculate and print the result.
    static void TwoSidesAndAngle()
    {
        Console.Write("|   Enter length of the side A:               |");
        double sideA;
        Console.SetCursorPosition(32, 10);
        if (double.TryParse(Console.ReadLine(), out sideA))
        {
            Console.Write("|   Enter length of the side B:               |");
            Console.SetCursorPosition(32, 11);
            double sideB;
            if (double.TryParse(Console.ReadLine(), out sideB))
            {
                Console.Write("|   Enter angle between them:                 |");
                Console.SetCursorPosition(30, 12);
                int angle;
                if (int.TryParse(Console.ReadLine(), out angle))
                {
                    SingleLine();
                    Console.WriteLine("|   Surface is {0}", TriangleSurface(sideA, sideB, angle));
                    Console.SetCursorPosition(46, 14);
                    Console.WriteLine("|");
                    DoubleLine();
                    return;
                }
            }
            Console.WriteLine("|   Unable to parse!                          |");
            DoubleLine();
        }
    }

    // Prints Error Message
    static void ErrorMessage()
    {
        Console.WriteLine("|   Enter correct value please!               |");
        DoubleLine();
    }

    // Prints Goodbye! message
    static void Exit()
    {
        Console.WriteLine("|   Goodbye!                                  |");
        DoubleLine();
    }

    // Print DoubleLine
    static void DoubleLine()
    {
        Console.WriteLine("===============================================");
    }

    // Prints Single Line
    static void SingleLine()
    {
        Console.WriteLine("|---------------------------------------------|");
    }
}

/**Console output:

===============================================
|         Triangle Surface Calculator         |
===============================================
|   1 -> Side and an altitude.                |
|   2 -> Three sides.                         |
|   3 -> Two sides and an angle between them. |
|---------------------------------------------|
|   4 -> Exit.                                |
===============================================1
|   Enter length of the side: 50              |
|   Enter length of the altitude: 20          |
|---------------------------------------------|
|   Surface is 500                            |
===============================================
**/