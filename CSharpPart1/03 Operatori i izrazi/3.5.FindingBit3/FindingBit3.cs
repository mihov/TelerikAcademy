// 3.5. Write a boolean expression for finding if the bit 3 
// (counting from 0) of a given integer is 1 or 0.

using System;

class FindingBit3
{
    static void Main()
    {
        // Declare a variable                                       bits 3210         bit 3210
        Console.Write("Enter integer number: ");
        int givenIntInit = int.Parse(Console.ReadLine()); // 204 =  1100 1100; 103 = 0110 0111;
        //                                                               ^                ^
        // Shift right
        int givenInt = givenIntInit >> 3;

        // Apply mask 0001
        givenInt = givenInt & 1;

        // Print the result on the console
        Console.WriteLine("Third bit of {0} is {1}.", givenIntInit, givenInt);
    }
}
/** Console output:
Enter integer number: 204
Third bit of 204 is 1.
Press any key to continue . . .

**/