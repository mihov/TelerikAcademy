// 06. Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter a binary number: ");

        // Reads binary number
        string binaryNumber = Console.ReadLine();

        // Check is this binary number
        if (IsBinaryNumber(binaryNumber))
        {

            // Check whether it is necessary to put leading zeros.
            if (binaryNumber.Length % 4 != 0)
            {
                // Put leading zeros
                binaryNumber = PutZeroAtTop(binaryNumber);
            }

            // Convert and print the result.
            Console.WriteLine("Hexadecimal representation of {0} is {1}.", binaryNumber, BinToHex(binaryNumber));
        }
        else
        {
            // Print error message.
            Console.WriteLine("{0} is not a binary number!", binaryNumber);
        }
    }

    /// <summary>
    /// Put leading zeros.
    /// </summary>
    /// <param name="binValue">Binary number as string.</param>
    /// <returns>Binary number as string with leading zeros, multiple of four.</returns>
    static string PutZeroAtTop(string binValue)
    {
        return (new string('0', 4 - (binValue.Length % 4))) + binValue;
    }

    /// <summary>
    /// Convert binary to hexadecimal number.
    /// </summary>
    /// <param name="binValue">Binary number as string.</param>
    /// <returns>Hrxadecimal number as string.</returns>
    static string BinToHex(string binValue)
    {
        // Define an empty string
        string result = string.Empty;
        
        // Lopp for all elements of binary number, increase by 4
        for (int position = 0; position < binValue.Length; position += 4)
        {
            // Create the result
            result =result + BinToHexChar(binValue.Substring(position, 4));
        }
        return result;
    }

    /// <summary>
    /// Convert one binary quartet to hexadecimal char.
    /// </summary>
    /// <param name="binValue">Binary number as string.</param>
    /// <returns>Hrxadecimal number as char.</returns>
    static char BinToHexChar(string binValue)
    {
        switch (binValue)
        {
            case "0000": return '0';
            case "0001": return '1';
            case "0010": return '2';
            case "0011": return '3';
            case "0100": return '4';
            case "0101": return '5';
            case "0110": return '6';
            case "0111": return '7';
            case "1000": return '8';
            case "1001": return '9';
            case "1010": return 'A';
            case "1011": return 'B';
            case "1100": return 'C';
            case "1101": return 'D';
            case "1110": return 'E';
            case "1111": return 'F';
            default: return ' ';
        }
    }


    /// <summary>
    /// Checks whether the string is a binary number.
    /// </summary>
    /// <param name="isBinary">Binary number as string</param>
    /// <returns>Is binary or not.</returns>
    static bool IsBinaryNumber(string isBinary)
    {
        // Is length is positive
        if (isBinary.Length <= 0)
        {
            return false;
        }
        
        // Is all char are 1 or 0
        for (int index = 0; index < isBinary.Length; index++)
        {
            if (isBinary[index] != '0' && isBinary[index] != '1')
            {
                return false;
            }
        }
        return true;
    }
}

/** Console output:
Enter a binary number: 101010111100110111101111
Hexadecimal representation of 101010111100110111101111 is ABCDEF.
Press any key to continue . . .
 **/
