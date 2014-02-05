//2.8. Declare two string variables and assign them with following value:
//	The "use" of quotations causes difficulties.
//	Do the above in two different ways: with and without using quoted strings.

using System;

class TwoStrings
{
    static void Main()
    {
        //Declare string varibales
        string stringOne = "The \"use\" of quotations causes difficulties.";
        string stringTwo = @"The ""use"" of quotations causes difficulties.";

        // Print first way on the console
        Console.Write("First way of assign: ");
        Console.WriteLine(stringOne);

        // Separation lines
        Console.WriteLine("\n");

        // Print seccond way on the console
        Console.Write("Seccond way of assign: ");
        Console.WriteLine(stringTwo);

        //Wait for key press
        Console.ReadKey();
    }
}
