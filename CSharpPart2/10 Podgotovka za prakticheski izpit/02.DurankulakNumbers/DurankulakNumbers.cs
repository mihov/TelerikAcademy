using System;
using System.Collections.Generic;

namespace _02.DurankulakNumbers
{
    class DurankulakNumbers
    {
        static void Main()
        {
            string duranKolagNumber = Console.ReadLine();
            List<int> convertedDurankolag = new List<int>();
            List<string> digits = new List<string>();
            
            GenerateDigits(digits);

            for (int counter = 0; counter < duranKolagNumber.Length; counter++)
            {
                string durDigit = String.Empty;
                
                if (char.IsLower(duranKolagNumber[counter]))
                {
                    durDigit = duranKolagNumber.Substring(counter, 2);
                    counter++;
                }
                else
                {
                    durDigit = duranKolagNumber[counter].ToString();
                }
                convertedDurankolag.Add(digits.IndexOf(durDigit));
            }

            long decimalNumber = 0;
            
            for (int counter = 0, subCount = convertedDurankolag.Count - 1; counter < convertedDurankolag.Count; counter++, subCount--)
            {
                decimalNumber += convertedDurankolag[counter] * (long)Math.Pow(168, subCount);
            }
            
            Console.WriteLine(decimalNumber);
        }

        static void GenerateDigits(List<string> digits)
        {
            
            for (char counter = 'A'; counter <= 'Z'; counter++)
            {
                digits.Add(counter.ToString());
            }
            
            for (char counter = 'a'; counter <= 'z'; counter++)
            {
                
                for (char subCount = 'A'; subCount <= 'Z'; subCount++)
                {
                    digits.Add(counter.ToString() + subCount.ToString());
                }
            }
        }
    }
}
