// 02. Write a program to convert binary numbers to their decimal representation.

using System;


class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter binary number: ");

        // Reads binary number
        string binaryNumber = Console.ReadLine();

        // Check is this binary number
        if (IsBinaryNumber(binaryNumber))
        {
            // Convert and print the result.
            Console.WriteLine("Decimal representation of {0} is {1}.", binaryNumber, BinToDec(binaryNumber));
        }
        else
        {
            // Print error message.
            Console.WriteLine("{0} is not a binary number!", binaryNumber);
        }
    }

    /// <summary>
    /// Checks whether the string is a binary number.
    /// </summary>
    /// <param name="isBinary">Binary number as string</param>
    /// <returns>Is binary or not.</returns>
    static bool IsBinaryNumber(string isBinary)
    {
        for (int index = 0; index < isBinary.Length; index++)
        {
            if (isBinary[index] != '0' && isBinary[index] != '1')
            {
                return false;
            }
        }
        return true;
    }

    /// <summary>
    /// Returns decimal representation of their binary numbers
    /// </summary>
    /// <param name="binaryNumber">Binary number.</param>
    /// <returns>Decimal number.</returns>
    static int BinToDec(string binaryNumber)
    {
        int result = 0;

        // Loop for all binary elements 
        for (int position = binaryNumber.Length - 1; position >= 0; position--)
        {
            // result = a*2^0+b*2^1+c*2^2+d*2^3......  where "abcd" is binary number
            result += int.Parse(binaryNumber[position].ToString()) * Power(2, binaryNumber.Length - position - 1);
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
}

/** Console output:
Enter binary number: 10101010
Decimal representation of 10101010 is 170.
Press any key to continue . . .
**/