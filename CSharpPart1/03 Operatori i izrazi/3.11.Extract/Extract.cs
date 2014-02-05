// 3.11. Write an expression that extracts from a given integer i the value of a given bit number b.
// Example: i=5; b=2 => value=1.

using System;

class Extract
{
    static void Main()
    {
        // Declare some variables 
        Console.Write("Enter some integer: ");
        int value = int.Parse(Console.ReadLine());
        int valueEnd = value;

        Console.Write("Enter the bit, who you want to know: ");
        int bitNumber = int.Parse(Console.ReadLine());

        // Shift bitNumber positions to right
        value = value >> bitNumber;

        // Apply mask 0001
        value = value & 1;

        // Print the result on the console
        Console.WriteLine("\ni = {0}; b = {1} => value = {2}.", valueEnd, bitNumber, value);
    }
}
/** Console output:
Enter some integer: 5
Enter the bit, who you want to know: 2

i = 5; b = 2 => value = 1.
Press any key to continue . . .
**/