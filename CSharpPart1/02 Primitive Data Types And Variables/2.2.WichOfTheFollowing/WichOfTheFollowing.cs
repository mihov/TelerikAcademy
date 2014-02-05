//2.2. Which of the following values can be assigned to a variable of type float 
//and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?

using System;

class WichOfTheFollowing
{
    static void Main()
    {
        // Declare variables
        double varDbl1 = 34.567839023;
        double varDbl2 = 8923.1234857;

        float varFloat1 = 12.345F;
        float varFloat2 = 3456.091F;

        // Print on the console to test the results
        Console.WriteLine("The variable 34.567839023 as Double look like {0}",varDbl1);
        Console.WriteLine("The variable 12.345 as Float look like {0}", varFloat1);
        Console.WriteLine("The variable 8923.1234857 as Double look like {0}", varDbl2);
        Console.WriteLine("The variable 3456.091 as Double look like {0}", varFloat2);

        //Wait for key
        Console.ReadKey();              
    }
}

