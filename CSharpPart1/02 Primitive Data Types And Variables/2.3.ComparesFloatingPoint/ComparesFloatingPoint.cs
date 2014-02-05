//2.3. Write a program that safely compares floating-point numbers with precision of 0.000001. 
//Examples: (5.3 ; 6.01) -> false;  (5.00000001 ; 5.00000003) -> true

using System;

class ComparesFloatingPoint
{
    static void Main()
    {
        // Declare variables
        float number1 = 5.3f;
        float number2 = 6.01f;
        
        // Print the results on the console
        Console.WriteLine("Is 5.3 = 6.01?               =>  {0}", number1==number2);
        
        //Two lines separation
        Console.WriteLine("\n\n");
        
        // Declare variables
        float numberDouble1 = 5.00000001f;
        float numberDouble2 = 5.00000003f;

        // Print the results on the console
        Console.WriteLine("Is 5.00000001 = 5.00000003?  =>  {0}", numberDouble1 == numberDouble2);
        
        //Wait for key press
        Console.ReadKey();
    }
}