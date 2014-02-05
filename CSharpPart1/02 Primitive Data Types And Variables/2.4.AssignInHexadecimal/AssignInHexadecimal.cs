//2.4. Declare an integer variable and assign it with the value 254 in hexadecimal format. 
//Use Windows Calculator to find its hexadecimal representation.

using System;

class AssignInHexadecimal
{
    static void Main()
    {
        // Declare variables
        int hexVar = 0xFE;

        // Print the results on the console
        Console.WriteLine("Hexadecimal value of {0:X} as decimal is {0}.", hexVar);

        //Wait for key press
        Console.ReadKey();
    }
}
