// 3.10. Write a boolean expression that returns if the bit at position p (counting from 0)
// in a given integer number v has value of 1. Example: v=5; p=1 ->false.

using System;

class BitPosition
{
    static void Main()
    {
        // Declare some variables

        Console.Write("Enter integer number v: ");

        int value;

        if (!(int.TryParse(Console.ReadLine(), out value)))  // Read the value for "v" and try to convert
        {
            Console.WriteLine("Unable to convert.");            // If unable close the application 
            Environment.Exit(0);
        }
        int valueEnd = value;
        
        Console.Write("Enter bit position p  : ");

        int position;

        if (!(int.TryParse(Console.ReadLine(), out position)))  // Read the value for "v" and try to convert
        {
            Console.WriteLine("Unable to convert.");            // If unable close the application 
            Environment.Exit(0);
        }

        // Shift P positions to right
        value = value >> position;

        // Compare by 0001
        value = value & 1;

        // Print the result 
        Console.WriteLine("v={0}; p={1} -> {2}.\n\n", valueEnd, position, value == 1);

        // Print the same result, but more friendly
        if (value == 1)
        {
            Console.WriteLine("In number {0} at position {1} has 1.", valueEnd, position);
        }
        else
        {
            Console.WriteLine("In number {0} at position {1} has no 1.", valueEnd, position);
        }
    }
}
/** Console output:

Enter integer number v: 5
Enter bit position p  : 1
v=5; p=1 -> False.


In number 5 at position 1 has no 1.
Press any key to continue . . . 
  
 **/