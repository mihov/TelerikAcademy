// 09. Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format (the C# type float).
// Example: -27,25 --> sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.

using System;

class FloatinPoint
{
    static void Main()
    {
        Console.Write("Enter 32-bit signed floating-point number: ");
        float flPntNumber = float.Parse(Console.ReadLine());

        string resultSign = string.Empty;
        if (flPntNumber >= 0)
        {
            resultSign = "0";
        }
        else
        {
            resultSign = "1";
        }


        if (flPntNumber < 0)
        {
            flPntNumber = -flPntNumber;
        }

        string intPartBin = GetBinaryInt((int)flPntNumber);
        string floPartBin = GetBinaryFraction(flPntNumber - (int)flPntNumber);

        // Exponent
        string resultExponent = string.Empty;
        if (intPartBin != "0")
        {
            resultExponent = GetBinaryInt(127 + intPartBin.Length - 1).PadLeft(8, '0');
        }
        else
        {
            resultExponent = GetBinaryInt(127 - (floPartBin.IndexOf('1') + 1)).PadLeft(8, '0');
        }

        // Mantissa
        string resultMantisa = string.Empty;
        if (intPartBin != "0")
        {
            resultMantisa = (intPartBin + floPartBin).Substring(1).PadRight(23, '0');
        }
        else
        {
            resultMantisa = (intPartBin + floPartBin).Substring(floPartBin.IndexOf('1') + 2).PadRight(23, '0');
        }

        // Print the result
        Console.WriteLine("sign = {0}, exponent = {1}, mantissa = {2}.", resultSign, resultExponent, resultMantisa);
    }

    static string GetBinaryInt(int num)
    {
        string result = "";

        do
        {
            result = (num & 1) + result;
            num >>= 1;
        } while (num != 0);

        return result;
    }

    static string GetBinaryFraction(float fl)
    {
        string result = "";

        do
        {
            fl = fl * 2;
            result += (int)fl;
            fl = fl - (int)fl;
        } while (fl != 0 || result.Length == 23); 
        return result;
    }
}

/** Console output:
Enter 32-bit signed floating-point number: -27.75
sign = 1, exponent = 10000011, mantissa = 10111100000000000000000.
Press any key to continue . . .
 **/

