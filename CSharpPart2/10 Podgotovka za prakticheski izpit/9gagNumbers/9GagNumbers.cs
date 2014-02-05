using System;
using System.Collections.Generic;
using System.Numerics;

namespace _9gagNumbers
{
    class T9GagNumbers
    {
        static void Main()
        {

            string gagNumber = Console.ReadLine();
            List<byte> convertedGag = new List<byte>();

            for (int counter = 0; counter < gagNumber.Length; counter++)
            {
                switch (gagNumber[counter])
                {
                    case '*':
                        if (gagNumber[counter + 1] == '*')
                        {
                        
                            convertedGag.Add(1);
                            counter += 1;
                        }
                        else
                        {
       
                            convertedGag.Add(6);
                            counter += 3;
                        }
                        break;
                    case '-':
                        convertedGag.Add(0);
                        counter += 1;
                        break;
                    case '!':
                        if (gagNumber[counter + 1] == '!')
                        {
                            if (gagNumber[counter + 2] == '!')
                            {
                                convertedGag.Add(2);
                                counter += 2;
                            }
                            else
                            {
                                convertedGag.Add(8);
                                counter += 5;
                            }
                        }
                        else
                        {
                            convertedGag.Add(5);
                            counter += 1;
                        }
                        break;
                    case '&':
                        if (gagNumber[counter + 1] == '*')
                        {
                            convertedGag.Add(7);
                            counter += 2;
                        }
                        else
                        {
                            if (gagNumber[counter + 1] == '&')
                            {
                                convertedGag.Add(3);
                                counter += 1;
                            }
                            else if (gagNumber[counter + 1] == '-')
                            {
                                convertedGag.Add(4);
                                counter += 1;
                            }
                        }
                        break;
                    default:
                        break;
                }
            }

            BigInteger decimalNumber = 0;
            for (int i = 0, j = convertedGag.Count - 1; i < convertedGag.Count; i++, j--)
            {
                decimalNumber += convertedGag[i] * BigInteger.Pow(9, j);
            }
            Console.WriteLine(decimalNumber);
        }
    }
}
