//2.11. Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

using System;

class DeclareInteger
{
    static void Main()
    {
        // Declare variables
        int varTime = 5;
        int varAge = 10;

        // Print Init Values
        Console.WriteLine("Init value of varTime is [{0}]", varTime);
        Console.WriteLine("Init value of varAge  is [{0}]\n", varAge);
        
        // Exchange values
        varTime++;
        varAge = (varAge + varTime) * varTime;

        // Print the result on the console
        Console.WriteLine("Current value of varTime is [{0}]", varTime);
        Console.WriteLine("Current value of varAge  is [{0}]", varAge);

        // Wait for key
        Console.ReadKey();

    }
}
    