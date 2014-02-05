// 01. Write a program to convert decimal numbers to their binary representation.

using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter decimal integer number: ");
        int decimalInteger;
        string decimalAsString = Console.ReadLine();

        // If parse was successful convert decimal to binary
        if (int.TryParse(decimalAsString, out decimalInteger))
        {
            // Convert and print.
            Console.WriteLine("Binary representation of {0} is {1}.", decimalAsString, DecToBin(decimalInteger));
        }
        else
        {
            // Error message.
            Console.WriteLine("Unable to convert!");
        }
    }

    /// <summary>
    /// Convert decimal to binary.
    /// </summary>
    /// <param name="decimalInt">Integer Decimal.</param>
    /// <returns>Binary representation.</returns>
    static string DecToBin(int decimalInt)
    {
        // Define and get 
        int number = decimalInt;
        int quot;
        string reminder = string.Empty;

        // Loop for all division by 2
        while (number >= 1)
        {
            quot = number / 2;
            reminder += (number % 2).ToString();
            number = quot;
        }

        // Declare empty string for result.
        string binary = string.Empty;

        // Reverse the result
        for (int i = reminder.Length - 1; i >= 0; i--)
        {
            binary = binary + reminder[i];
        }

        return binary;
    }
}

/** Console output:
Enter decimal integer number: 8
Binary representation of 8 is 1000.
Press any key to continue . . .
**/