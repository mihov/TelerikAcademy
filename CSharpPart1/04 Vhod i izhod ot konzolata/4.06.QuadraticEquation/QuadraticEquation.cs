// 4.6. Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).

using System;
using System.Text;

class QuadraticEquation
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode; // Set unicode for console
        Console.WriteLine("Enter coefficients of a quadratic equation:");

        // Read coefficient a
        Console.Write("a = ");
        double coeffA;
        if (!(double.TryParse(Console.ReadLine(), out coeffA)))
        {
            Console.WriteLine("Unable to convert!");
            Environment.Exit(0);                        // Close the application if unable to konvert
        }
        else if (coeffA == 0)
        {
            Console.WriteLine("Coefficient A can not be zero!");
            Environment.Exit(0);                        // Close the application if coefficient a = 0
        }

        // Read coefficient b
        Console.Write("b = ");
        double coeffB;
        if (!(double.TryParse(Console.ReadLine(), out coeffB)))
        {
            Console.WriteLine("Unable to convert!");
            Environment.Exit(0);                        // Close the application if unable to konvert
        }

        // Read coefficient c
        Console.Write("c = ");
        double coeffC;
        if (!(double.TryParse(Console.ReadLine(), out coeffC)))
        {
            Console.WriteLine("Unable to convert!");
            Environment.Exit(0);                        // Close the application if unable to konvert
        }

        // Declare variables
        double discriminant;
        double root1, root2;

        //Calculating the discriminant
        discriminant = coeffB * coeffB - 4 * coeffA * coeffC;

        if (discriminant == 0)
        {
            root1 = root2 = -coeffB / (2 * coeffA);
            Console.WriteLine("\nThe root is {0}.", root1);
            Console.ReadLine();
        }
        else if (discriminant < 0) //If discriminant < 0, no solutions are possible
        {
            Console.WriteLine("\nThere are no real root.");
            Console.ReadLine();
        }
        else //If discriminant > 0, there are two possible solutions
        {
            root1 = (-coeffB - Math.Sqrt(discriminant)) / (2 * coeffA);
            root2 = (-coeffB + Math.Sqrt(discriminant)) / (2 * coeffA);
            Console.WriteLine("\nRoots of quadratic equation are:");
            Console.WriteLine("    root 1 = {0}\n    root 2 = {1}", root1, root2);
        }
    }
}
/** Console output:
Enter coefficients of a quadratic equation:
a = 2
b = -5
c = 2

Roots of quadratic equation are:
    root 1 = 0,5
    root 2 = 2
Press any key to continue . . .
**/