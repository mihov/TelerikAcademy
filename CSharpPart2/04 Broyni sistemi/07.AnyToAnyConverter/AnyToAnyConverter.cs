// 07. Write a program to convert from any numeral system of given base s
// to any other numeral system of base d (2 ≤ s, d ≤  16).

using System;

class AnyToAnyConverter
{
    private const string posibleValueList = "0123456789ABCDEF";

    static void Main()
    {
        Console.WriteLine(" Any to any numeral system converter.");
        Console.WriteLine("======================================");
        Console.Write("Enter the base of numeral system \nFROM: ");
        // Define numeral system FROM
        byte nsFrom;
        if (byte.TryParse(Console.ReadLine(), out nsFrom) && nsFrom >= 2 && nsFrom <= 16)
        {
            Console.Write("\nEnter the base of numeral system \n  TO: ");
            // Define numeral system TO
            byte nsTo;
            if (byte.TryParse(Console.ReadLine(), out nsTo) && nsFrom >= 2 && nsFrom <= 16)
            {
                Console.Write("\nEnter number to convert to: ");
                string numberFrom = Console.ReadLine();

                if (IsProperNS(numberFrom, nsFrom))
                {
                    Console.Write("\n{0} of base {1} in base {2} is: ", numberFrom, nsFrom, nsTo);
                    Console.WriteLine(AnyToAnyNumSysConv(numberFrom, nsFrom, nsTo));
                }
                else
                {
                    Console.WriteLine("Improper value!");
                }
            }
            else
            {
                Console.WriteLine("Improper value!");
            }

        }
        else
        {
            Console.WriteLine("Improper value!");
        }

    }

    /// <summary>
    /// Check is FROM number is in proper numeral system
    /// </summary>
    /// <param name="numberFrom">FROM number</param>
    /// <param name="nsFrom">Numeral System FROM</param>
    /// <returns></returns>
    static bool IsProperNS(string numberFrom, byte nsFrom)
    {
        for (int index = 0; index < numberFrom.Length; index++)
        {
            if (!
                    (posibleValueList.IndexOf(numberFrom[index]) >= 0
                    &&
                    (posibleValueList.IndexOf(numberFrom[index]) <= nsFrom - 1))
                )
            {
                return false;
            }


        }
        return true;
    }

    static string AnyToAnyNumSysConv(string numberFrom, byte nsFrom, byte nsTo)
    {
        return DecToAny(AnyToDec(numberFrom, nsFrom), nsTo);
    }

    /// <summary>
    /// /Decimal to any converter
    /// </summary>
    /// <param name="decimalInt">Any decimal value</param>
    /// <param name="baseValue">New numeral system base</param>
    /// <returns>Converted to new numeral system</returns>
    static string DecToAny(int decimalInt, byte baseValue)
    {
        // Define and get 
        int number = decimalInt;
        int quot;
        string reminder = string.Empty;

        // Loop for all division by base
        while (number >= 1)
        {
            quot = number / baseValue;
            reminder += DecToAnyChar(number % baseValue);
            number = quot;
        }

        // Declare empty string for result.
        string anyNumber = string.Empty;

        // Reverse the result
        for (int i = reminder.Length - 1; i >= 0; i--)
        {
            anyNumber = anyNumber + reminder[i];
        }

        return anyNumber;
    }

    /// <summary>
    /// Convert any numeral system to decimal
    /// </summary>
    /// <param name="anylNumber">Any number</param>
    /// <param name="baseValue">Base of current numeral system</param>
    /// <returns>Converted decimal number</returns>
    static int AnyToDec(string anylNumber, byte baseValue)
    {
        int result = 0;
        anylNumber = anylNumber.ToUpper();

        // Loop for all binary elements 
        for (int position = anylNumber.Length - 1; position >= 0; position--)
        {
            // Calculate the result
            result += AnyToDecChar(anylNumber[position]) * Power(baseValue, anylNumber.Length - position - 1);
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
    /// <param name="anyValue">Decimal</param>
    /// <returns>Hexadecimal char</returns>
    static int AnyToDecChar(char anyValue)
    {
        return posibleValueList.IndexOf(anyValue);
    }

    /// <summary>
    /// Convert integer 0 - 15 to char 0 - F
    /// </summary>
    /// <param name="anyValue">Decimal</param>
    /// <returns>Hexadecimal char</returns>
    static char DecToAnyChar(int anyValue)
    {
        return posibleValueList[anyValue];
    }
}

/** Console output:
 Any to any numeral system converter.
======================================
Enter the base of numeral system
FROM: 2

Enter the base of numeral system
  TO: 16

Enter number to convert to: 101010111100110111101111

101010111100110111101111 of base 2 in base 16 is: ABCDEF
Press any key to continue . . .
**/