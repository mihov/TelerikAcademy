// 08. Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;

class ShortAsBinary
{
    static void Main()
    {

        Console.Write("Enter 16-bit signed integer number: ");
        short decimalShortInteger;
        string decimalAsString = Console.ReadLine();

        // If parse was successful convert decimal to binary
        if (short.TryParse(decimalAsString, out decimalShortInteger))
        {
            // Convert and print.
            Console.WriteLine("Binary representation of {0} is \t{1}.\n", decimalAsString, DecToBin(decimalShortInteger));
            Console.WriteLine("==========================  TEST  ===========================");
            Console.WriteLine("Binary representation of {0} is \t{1}.", short.MaxValue, DecToBin(short.MaxValue));
            Console.WriteLine("Binary representation of {0} is \t{1}.", short.MaxValue - 1, DecToBin(short.MaxValue - 1));
            Console.WriteLine("...");
            for (int counter = 3; counter >= -3; counter--)
            {
                Console.WriteLine("Binary representation of {0} is \t\t{1}.", counter, DecToBin(counter));
            }
            Console.WriteLine("...");
            Console.WriteLine("Binary representation of {0} is \t{1}.", short.MinValue + 1, DecToBin(short.MinValue + 1));
            Console.WriteLine("Binary representation of {0} is \t{1}.", short.MinValue, DecToBin(short.MinValue));
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
        int number;

        if (decimalInt >= 0)
        {
            number = decimalInt;
        }
        else
        {
            // Prepares a negative number for conversion. 
            number = 32768 + decimalInt;
        }


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

        // Put 0 or 1 depending on the sign.
        if (decimalInt >= 0)
        {
            return binary.PadLeft(16, '0');
        }
        else
        {
            return '1' + binary.PadLeft(15, '0');
        }
    }
}

/** Console output:
Enter 16-bit signed integer number: 768
Binary representation of 768 is         0000001100000000.

==========================  TEST  ===========================
Binary representation of 32767 is       0111111111111111.
Binary representation of 32766 is       0111111111111110.
...
Binary representation of 3 is           0000000000000011.
Binary representation of 2 is           0000000000000010.
Binary representation of 1 is           0000000000000001.
Binary representation of 0 is           0000000000000000.
Binary representation of -1 is          1111111111111111.
Binary representation of -2 is          1111111111111110.
Binary representation of -3 is          1111111111111101.
...
Binary representation of -32767 is      1000000000000001.
Binary representation of -32768 is      1000000000000000.
Press any key to continue . . .
 **/
