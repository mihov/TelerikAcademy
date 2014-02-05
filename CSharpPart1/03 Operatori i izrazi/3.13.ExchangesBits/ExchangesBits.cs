// 3.13. Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class ExchangesBits
{
    static void Main()
    {
        // Read the 32-bit unsigned integer number from the console
        Console.Write("Enter unsigned integer: ");
        uint unsignInt = uint.Parse(Console.ReadLine());        // 4294901760 is a good number for this example it is  11111111111111110000000000000000 
                                                                // another good number is 65535    00000000000000001111111111111111
        // Print position of bits and the number as binary
        Console.WriteLine("\n\n\nPositions of bits                         3         2         1         0");
        Console.WriteLine("                                         10987654321098765432109876543210");
        Console.WriteLine("\nThe binary  number  is:                  {0}", Convert.ToString(unsignInt, 2).PadLeft(32, '0'));

        // Print the mask and extract 3 4 5 bits
        Console.WriteLine("The mask for 3 4 5  is:                  {0}", Convert.ToString(7 << 3, 2).PadLeft(32, '0'));
        uint bit345 = (unsignInt & (7 << 3)) >> 3;
        Console.WriteLine("\nThe bits 3 4 5 are  :                    {0}", Convert.ToString(bit345, 2).PadLeft(3, '0'));

        // Print the mask and extract 24 25 26 bits
        uint bit242526 = (unsignInt & (7 << 24)) >> 24;
        Console.WriteLine("\nThe binary  number  is:                  {0}", Convert.ToString(unsignInt, 2).PadLeft(32, '0'));
        Console.WriteLine("The mask for 24 25 26 is:                {0}", Convert.ToString(7 << 24, 2).PadLeft(32, '0'));
        Console.WriteLine("\nThe bits 24 25 26 are :                  {0}", Convert.ToString(bit242526, 2).PadLeft(3, '0'));

        // Put zeroes on the exchange positions
        uint newNumber = (uint)(unsignInt & (~(7 << 24)));
        newNumber = (uint)(newNumber & (~(7 << 3)));

        // Print the number with zeroes on the exchange positions
        Console.WriteLine("\nZeroes on the exchange positions:        {0}", Convert.ToString(newNumber, 2).PadLeft(32, '0'));

        // Shift extracted bits on their new position in the number
        uint exchangeNumber = newNumber | (bit242526 << 3);
        exchangeNumber = exchangeNumber | (bit345 << 24);

        // Print old and new number
        Console.WriteLine("\nThe binary  number again is:             {0}", Convert.ToString(unsignInt, 2).PadLeft(32, '0'));
        Console.WriteLine("The Exchanged binary number is:          {0}\n\n", Convert.ToString(exchangeNumber, 2).PadLeft(32, '0'));
    }
}
    /** Console output:
    Enter unsigned integer: 4294901760



    Positions of bits                         3         2         1         0
                                             10987654321098765432109876543210

    The binary  number  is:                  11111111111111110000000000000000
    The mask for 3 4 5  is:                  00000000000000000000000000111000

    The bits 3 4 5 are  :                    000

    The binary  number  is:                  11111111111111110000000000000000
    The mask for 24 25 26 is:                00000111000000000000000000000000

    The bits 24 25 26 are :                  111

    Zeroes on the exchange positions:        11111000111111110000000000000000

    The binary  number again is:             11111111111111110000000000000000
    The Exchanged binary number is:          11111000111111110000000000111000


    Press any key to continue . . .
    **/