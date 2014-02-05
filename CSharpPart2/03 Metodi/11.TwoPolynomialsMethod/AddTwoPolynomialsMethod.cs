// 11. Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
// 		x2 + 5 = 1x2 + 0x + 5  --> 5 0 1

using System;

    class AddTwoPolynomialsMethod
    {
        static void Main()
        {
            decimal[] firstPolynom = { 4, -1 };
            Console.Write("First  Polynom:           ");
            PrintPolynom(firstPolynom);

            decimal[] secondPolynom = { 9, -4, 5 };
            Console.Write("Second Polynom:           ");
            PrintPolynom(secondPolynom);

            int maxLenght = 0;
            if (firstPolynom.Length > secondPolynom.Length)
            {
                maxLenght = firstPolynom.Length;
            }
            else
            {
                maxLenght = secondPolynom.Length;
            }

            decimal[] result = new decimal[maxLenght];


            Sum(firstPolynom, secondPolynom, result);
            Console.WriteLine("-----------------------------------------------");
            Console.Write("Sum:                      ");
            PrintPolynom(result);
        }

        /// <summary>
        /// Prints polynoms
        /// </summary>
        /// <param name="polynom">Polynom as array</param>
        static void PrintPolynom(decimal[] polynom)
        {
            for (int i = polynom.Length - 1; i >= 0; i--)
            {
                if (polynom[i] != 0 && i != 0)
                {
                    if (polynom[i - 1] >= 0)
                    {
                        Console.Write("{1}x^{0} +", i, polynom[i]);
                    }
                    else
                    {
                        Console.Write("{1}x^{0} ", i, polynom[i]);
                    }
                }
                else if (i == 0)
                {
                    Console.Write("{0}", polynom[i]);
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Sum two polynoms
        /// </summary>
        /// <param name="firstPolynom">First Polynom</param>
        /// <param name="secondPolynom">Second Polynom</param>
        /// <param name="result">Sum of two polynoms as array</param>
        static void Sum(decimal[] firstPolynom, decimal[] secondPolynom, decimal[] result)
        {
            int minLenght = 0;
            int smallerPolynomial = 0;

            if (firstPolynom.Length > secondPolynom.Length)
            {
                minLenght = secondPolynom.Length;
                smallerPolynomial = 2;
            }
            else
            {
                minLenght = firstPolynom.Length;
                smallerPolynomial = 1;
            }
            for (int i = 0; i < minLenght; i++)
            {
                result[i] = firstPolynom[i] + secondPolynom[i];
            }
            for (int i = minLenght; i < result.Length; i++)
            {
                if (smallerPolynomial == 1)
                {
                    result[i] = secondPolynom[i];
                }
                else
                {
                    result[i] = firstPolynom[i];
                }
            }
        }
    }

/** Console output:
First  Polynom:           -1x^1 +4
Second Polynom:           5x^2 -4x^1 +9
-----------------------------------------------
Sum:                      5x^2 -5x^1 +13
Press any key to continue . . .
**/