using System;
using System.Collections.Generic;
using System.Numerics;

namespace _05.KaspichanNumbers
{
    class KaspichanNumbers
    {
        static void Main()
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            List<string> digits = new List<string>();
            List<int> kaspichanNumber = new List<int>();
            GenerateDigits(digits);
            if (input == 0)
            {
                kaspichanNumber.Add(0);
            }
            while (input != 0)
            {
                kaspichanNumber.Add((int)(input % 256));
                input /= 256;
            }
            for (int counter = kaspichanNumber.Count - 1; counter >= 0; counter--)
            {
                Console.Write(digits[kaspichanNumber[counter]]);
            }
        }

        static void GenerateDigits(List<string> digits)
        {
            for (char counter = 'A'; counter <= 'Z'; counter++)
            {
                digits.Add(counter.ToString());
            }

            for (char counter = 'a'; counter <= 'i'; counter++)
            {
                for (char subCounter = 'A'; subCounter <= 'Z'; subCounter++)
                {
                    digits.Add(counter.ToString() + subCounter.ToString());
                }
            }
        }
    }
}
