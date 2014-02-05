// 04. Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter hexadecimal number: ");

        // Reads hexadecimal number
        string hexadecimalNumber = Console.ReadLine();

        // Check is this hexadecimal number
        if (IsHexadecimalNumber(hexadecimalNumber))
        {
            // Convert and print the result.
            Console.WriteLine("Decimal representation of {0} is {1}.", hexadecimalNumber, HexadecimalToDec(hexadecimalNumber));
        }
        else
        {
            // Print error message.
            Console.WriteLine("{0} is not a hexadecimal number!", hexadecimalNumber);
        }
    }

    /// <summary>
    /// Checks whether the string is a hexadecimal number.
    /// </summary>
    /// <param name="isHexadecimal">Binary number as string</param>
    /// <returns>Is binary or not.</returns>
    static bool IsHexadecimalNumber(string isHexadecimal)
    {
        for (int index = 0; index < isHexadecimal.Length; index++)
        {
            int temp = (int)(isHexadecimal[index]);
            if (!((temp >= 48 && temp <= 57) || (temp >= 65 && temp <= 71) || (temp >= 97 && temp <= 102)))
            {
                return false;
            }
        }
        return true;
    }

    /// <summary>
    /// Returns decimal representation of their hexadecimal numbers
    /// </summary>
    /// <param name="hexadecimalNumber">Hexadecimal number.</param>
    /// <returns>Decimal number.</returns>
    static int HexadecimalToDec(string hexadecimalNumber)
    {
        int result = 0;
        hexadecimalNumber = hexadecimalNumber.ToUpper();

        // Loop for all binary elements 
        for (int position = hexadecimalNumber.Length - 1; position >= 0; position--)
        {
            // result = a*16^0+b*16^1+c*16^2+d*16^3......  where "abcd" is hexadecimal number
            result += HexToDecChar(hexadecimalNumber[position]) * Power(16, hexadecimalNumber.Length - position - 1);
        }

        // Return the result            
        return result;
    }

    /// <summary>
    /// Returns a specified number raised to the specified power.
    /// </summary>
    /// <param name="number">Number to be raised to a power.</param>
    /// <param name="power">Number that specifies a power.</param>
    /// <returns>The number raised to the power.</returns>
    static int Power(int number, int power)
    {
        int result = 1;

        // Loop for all raised count.
        for (int counter = 0; counter < power; counter++)
        {
            result *= number;
        }

        // Return the result
        return result;
    }

    /// <summary>
    /// Convert integer 0 - 15 to char 0 - F
    /// </summary>
    /// <param name="hexValue">Decimal</param>
    /// <returns>Hexadecimal char</returns>
    static int HexToDecChar(char hexValue)
    {
        switch (hexValue)
        {
            case 'A': return 10;
            case 'B': return 11;
            case 'C': return 12;
            case 'D': return 13;
            case 'E': return 14;
            case 'F': return 15;
            default: return (int)hexValue - 48;
        }
    }
}

/** Console output:
Enter hexadecimal number: ABCDEF
Decimal representation of ABCDEF is 11259375.
Press any key to continue . . .
**/