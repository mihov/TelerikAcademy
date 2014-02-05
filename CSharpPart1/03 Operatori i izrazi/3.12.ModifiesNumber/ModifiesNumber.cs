// 3.12. We are given integer number n, value v (v=0 or 1) and a position p.
// Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
//	Example: n = 5 (00000101), p=3, v=1 -> 13 (00001101)
//           n = 5 (00000101), p=2, v=0 -> 1  (00000001)

using System;

class ModifiesNumber
{
    static void Main()
    {
        // Read the 32-bit unsigned integer number from the console
        Console.Write("Enter unsigned integer n         : ");

        uint numberN;

        if (!(uint.TryParse(Console.ReadLine(), out numberN)))  // Read the value for "n" and try to convert
        {
            Console.WriteLine("Unable to convert.");            // If unable close the application 
            Environment.Exit(0);
        }

        Console.Write("Enter the value v (1 or 0)       : ");
        uint valueV;
        if (!(uint.TryParse(Console.ReadLine(), out valueV)))   // Read the value for "v" and try to convert
        {
            Console.WriteLine("Unable to convert.");            // If unable close the application 
            Environment.Exit(0);
        }
        else if ((valueV != 1) && (valueV != 0))                // Check is it 0 or 1
        {
            Console.WriteLine("Value is not 0 or 1");
            Environment.Exit(0);                                // Close the application if "v" is not 1 or 0
        }

        Console.Write("Enter the position p             : ");
        uint positionP;
        if (!(uint.TryParse(Console.ReadLine(), out positionP)))// Read the value for "p" and try to convert    
        {
            Console.WriteLine("Unable to convert.");            // If unable close the application
            Environment.Exit(0);
        }

        // Print the number as binary
        Console.WriteLine("\nThe binari number of n is        : {0}", Convert.ToString(numberN, 2).PadLeft(32, '0'));
        
        // Put zero on position "p"
        numberN = (uint)(numberN & (~(1 << (int)positionP)));
        
        // Print the number with zeroes on the exchange positions
        Console.WriteLine("Zero on the exchange positions p : {0}", Convert.ToString(numberN, 2).PadLeft(32, '0'));

        // Shift "v" on position "p" in the number and merge
        numberN = numberN | (valueV << (int)positionP);
        Console.WriteLine("The new binary number of n is    : {0}", Convert.ToString(numberN, 2).PadLeft(32, '0'));
        Console.WriteLine("The new number n is              : {0}", numberN);
    }
}
/** Console output:
Enter unsigned integer n         : 5
Enter the value v (1 or 0)       : 1
Enter the position p             : 3

The binari number of n is        : 00000000000000000000000000000101
Zero on the exchange positions p : 00000000000000000000000000000101
The new binary number of n is    : 00000000000000000000000000001101
The new number n is              : 13
Press any key to continue . . .
**/
