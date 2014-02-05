// 11. Write a program that reads a number and prints it as a decimal number,
// hexadecimal number, percentage and in scientific notation.
// Format the output aligned right in 15 symbols.

using System;

class ReadAndPrintNumber
{
    static void Main()
    {
        // Reads the number
        Console.Write("Enter a number: ");
        float theNumber = float.Parse(Console.ReadLine());

        // Print it formated.
        Console.WriteLine(String.Format("Decimal:               {0,15}", theNumber));
        Console.WriteLine(String.Format("Hexadecimal:           {0,15:X}", (int)theNumber));
        Console.WriteLine(String.Format("Rercentage:            {0,15:P}", theNumber));
        Console.WriteLine(String.Format("Scientific notation:   {0,15:E}", theNumber));
    }
}

/** Console output:
Enter a number: 10.5
Decimal:                          10.5
Hexadecimal:                         A
Rercentage:                 1 050.00 %
Scientific notation:     1.050000E+001
Press any key to continue . . .
**/