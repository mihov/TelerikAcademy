using System;

class HexadecimalToBinary
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
            Console.WriteLine("Binary representation of {0} is {1}.", hexadecimalNumber, HexToBin(hexadecimalNumber));
        }
        else
        {
            // Print error message.
            Console.WriteLine("{0} is not a hexadecimal number!", hexadecimalNumber);
        }
    }

    /// <summary>
    /// Returns decimal representation of their hexadecimal numbers
    /// </summary>
    /// <param name="hexadecimalNumber">Hexadecimal number.</param>
    /// <returns>Decimal number.</returns>
    static string HexToBin(string hexadecimalNumber)
    {
        string result = String.Empty;

        hexadecimalNumber = hexadecimalNumber.ToUpper();

        // Loop for all binary elements 
        for (int position = hexadecimalNumber.Length - 1; position >= 0; position--)
        {
            result += HexToBinChar(hexadecimalNumber[hexadecimalNumber.Length - position - 1]);
        }

        // Return the result            
        return result;
    }
    
    /// <summary>
    /// Convert Hexadecimal as char to binary as string;
    /// </summary>
    /// <param name="hexValue"> Hexadecimal as char.</param>
    /// <returns>Binary as string.</returns>
    static string HexToBinChar(char hexValue)
    {
        switch (hexValue)
        {
            case '0': return "0000";
            case '1': return "0001";
            case '2': return "0010";
            case '3': return "0011";
            case '4': return "0100";
            case '5': return "0101";
            case '6': return "0110";
            case '7': return "0111";
            case '8': return "1000";
            case '9': return "1001";
            case 'A': return "1010";
            case 'B': return "1011";
            case 'C': return "1100";
            case 'D': return "1101";
            case 'E': return "1110";
            case 'F': return "1111";
            default: return "";
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
}

/** Console output:
Enter hexadecimal number: abcdef
Binary representation of abcdef is 101010111100110111101111.
Press any key to continue . . .
**/