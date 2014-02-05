// 2.13. Create a program that assigns null values to an integer and to double variables. 
//Try to print them on the console, try to add some values or the null literal to them and see the result.

using System;

class NullValues
{
    static void Main()
    {
        // Declare null value to both variables
        int? nullIntVar = null;
        double? nullDblVar = null;

        // Print null values to the nonsole
        Console.WriteLine("Null values added.");
        Console.WriteLine("The value of nullIntVar is {0}.", nullIntVar);
        Console.WriteLine("The value of nullDblVar is {0}.", nullDblVar);

        // Assign some values
        nullIntVar = 32555;
        nullDblVar = -555666777;
        
        // Print the new values to the console
        Console.WriteLine("\nNew values added.");
        Console.WriteLine("The value of nullIntVar is {0}.", nullIntVar);
        Console.WriteLine("The value of nullDblVar is {0}.", nullDblVar);

        // Wait for key press.
        Console.ReadKey();
    }
}
