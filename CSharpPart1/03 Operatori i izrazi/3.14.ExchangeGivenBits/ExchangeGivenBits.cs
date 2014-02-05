// 3.14. * Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.

using System;

class ExchangeGivenBits
{
    static void Main()
    {
        Console.Write("Please enter one unsigned integer number.  : ");
        uint unInteger;
        if (!(uint.TryParse(Console.ReadLine(), out unInteger)))  // Read the value for unsigned integer and try to convert
        {
            Console.WriteLine("Unable to convert.");            // If unable close the application 
            Environment.Exit(0);
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        Console.Write("How many bits do you want to change? (1-32): ");
        uint numberOfBitsK;
        if (!(uint.TryParse(Console.ReadLine(), out numberOfBitsK)))  // Read the value for "k" and try to convert
        {
            Console.WriteLine("Unable to convert.");            // If unable close the application 
            Environment.Exit(0);
        }
        else if (!(numberOfBitsK >= 1) && (numberOfBitsK <= 32))
        {
            Console.WriteLine("Range of bits must be between 1 and 32.");            // If it is out of rage 1 - 32 close the application 
            Environment.Exit(0);
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        Console.Write("From bit (0 - {0}):", 31 - numberOfBitsK);
        uint bitsFrom;
        if (!(uint.TryParse(Console.ReadLine(), out bitsFrom)))  // Read the value for "p" and try to convert
        {
            Console.WriteLine("Unable to convert.");            // If unable close the application 
            Environment.Exit(0);
        }
        else if (!(32 - numberOfBitsK >= bitsFrom))
        {
            Console.WriteLine("Out of posible bits range!");            // If it is out of the rage of posible bits, close the application 
            Environment.Exit(0);
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        Console.Write("To bit ({0} - {1}):", 32 - numberOfBitsK - bitsFrom, 32 - numberOfBitsK);
        uint bitsTo;
        if (!(uint.TryParse(Console.ReadLine(), out bitsTo)))  // Read the value for "q" and try to convert
        {
            Console.WriteLine("Unable to convert.");            // If unable close the application 
            Environment.Exit(0);
        }
        else if (!(32 - numberOfBitsK >= bitsTo))
        {
            Console.WriteLine("Out of posible bits range!");            // If it is out of the rage of posible bits, close the application 
            Environment.Exit(0);
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // Print position of bits and the number as binary
        Console.WriteLine("\n\n\n");
        Console.WriteLine("Positions of bits                           3         2         1         0");
        Console.WriteLine("                                           10987654321098765432109876543210");
        Console.WriteLine("                  The binary  number  is : {0}\n", Convert.ToString(unInteger, 2).PadLeft(32, '0'));
        
        // Calculate length of mask
        uint bitsLength = (uint)Math.Pow(2, (numberOfBitsK))-1;

        // Print the length of mask
        Console.WriteLine("                      The length mask is : {0}\n", Convert.ToString(bitsLength, 2));

        
        // Create mask for FROM range of bits
        uint maskFrom = bitsLength << (int)bitsFrom;

        // Applay FROM mask and extract the bits
        uint fromBits = (unInteger & (maskFrom)) >> (int)bitsFrom;
        Console.WriteLine("                  The binary  number  is : {0}", Convert.ToString(unInteger, 2).PadLeft(32, '0'));
        Console.WriteLine("               The mask for FROM bis  is : {0}", Convert.ToString(maskFrom, 2).PadLeft(32, '0'));
        Console.WriteLine("                       The bits FROM are : {0}\n", Convert.ToString(fromBits, 2).PadLeft((int)numberOfBitsK, '0'));

        // Create mask for TO range of bits
        uint maskTo = bitsLength << (int)bitsTo;

        // Applay TO mask and extract the bits 
        uint toBits = (unInteger & (maskTo)) >> (int)bitsTo;
        Console.WriteLine("                  The binary  number  is : {0}", Convert.ToString(unInteger, 2).PadLeft(32, '0'));
        Console.WriteLine("                 The mask for TO bits is : {0}", Convert.ToString(maskTo, 2).PadLeft(32, '0'));
        Console.WriteLine("                         The bits TO are : {0}\n", Convert.ToString(toBits, 2).PadLeft((int)numberOfBitsK, '0'));

        // Put zeroes on the exchange positions
        uint newNumber = (uint)(unInteger & (~(bitsLength << (int)bitsTo)));
        newNumber = (uint)(newNumber & (~(bitsLength << (int)bitsFrom)));

        // Print the number with zeroes on the exchange positions
        Console.WriteLine("                  The binary  number  is : {0}", Convert.ToString(unInteger, 2).PadLeft(32, '0'));
        Console.WriteLine("        Zeroes on the exchange positions : {0}\n", Convert.ToString(newNumber, 2).PadLeft(32, '0'));

        // Shift extracted bits on their new position in the number
        uint exchangeNumber = newNumber | (toBits << (int)bitsFrom);
        exchangeNumber = exchangeNumber | (fromBits << (int)bitsTo);

        // Print old and new number
        Console.WriteLine("             The binary  number again is : {0}", Convert.ToString(unInteger, 2).PadLeft(32, '0'));
        Console.WriteLine("          The Exchanged binary number is : {0}\n\n", Convert.ToString(exchangeNumber, 2).PadLeft(32, '0'));
    }
}
        /** Console output:
        Please enter one unsigned integer number.  : 4042322160
        How many bits do you want to change? (1-32): 8
        From bit (0 - 23):4
        To bit (20 - 24):24




        Positions of bits                   3         2         1         0
                                           10987654321098765432109876543210
                  The binary  number  is : 11110000111100001111000011110000

                      The length mask is : 11111111

                  The binary  number  is : 11110000111100001111000011110000
               The mask for FROM bis  is : 00000000000000000000111111110000
                       The bits FROM are : 00001111

                  The binary  number  is : 11110000111100001111000011110000
                 The mask for TO bits is : 11111111000000000000000000000000
                         The bits TO are : 11110000

                  The binary  number  is : 11110000111100001111000011110000
        Zeroes on the exchange positions : 00000000111100001111000000000000

             The binary  number again is : 11110000111100001111000011110000
          The Exchanged binary number is : 00001111111100001111111100000000


        Press any key to continue . . .

        **/