// 03. Write a program to convert decimal numbers to their hexadecimal representation.

using System;

class DecimalToHexaDecimal
{
    static void Main()
    {
        Console.Write("Enter decimal integer number: ");
        int decimalInteger;
        string decimalAsString = Console.ReadLine();

        // If parse was successful convert decimal to hexadecimal
        if (int.TryParse(decimalAsString, out decimalInteger))
        {
            // Convert and print.
            Console.WriteLine("Hexadecimal representation of {0} is {1}.", decimalAsString, DecToHex(decimalInteger));
        }
        else
        {
            // Error message.
            Console.WriteLine("Unable to convert!");
        }
    }

    /// <summary>
    /// Convert Decimal to hexadecimal
    /// </summary>
    /// <param name="decimalInt">Decimal integre</param>
    /// <returns>Hexadecimal</returns>
    static string DecToHex(int decimalInt)
    {
        // Define and get 
        int number = decimalInt;
        int quot;
        string reminder = string.Empty;

        // Loop for all division by 16
        while (number >= 1)
        {
            quot = number / 16;
            reminder += DecToHexChar(number % 16);
            number = quot;
        }

        // Declare empty string for result.
        string hexa = string.Empty;

        // Reverse the result
        for (int i = reminder.Length - 1; i >= 0; i--)
        {
            hexa = hexa + reminder[i];
        }

        return hexa;
    }

    /// <summary>
    /// Convert integer 0 - 15 to char 0 - F
    /// </summary>
    /// <param name="decValue">Decimal</param>
    /// <returns>Hexadecimal char</returns>
    static char DecToHexChar(int decValue)
    {
        switch (decValue)
        {
            case 10: return 'A';
            case 11: return 'B';
            case 12: return 'C';
            case 13: return 'D';
            case 14: return 'E';
            case 15: return 'F';
            default: return decValue.ToString()[0];
        }
    }
}

/** Console output:
Enter decimal integer number: 11259375
Hexadecimal representation of 11259375 is ABCDEF.
Press any key to continue . . .
**/