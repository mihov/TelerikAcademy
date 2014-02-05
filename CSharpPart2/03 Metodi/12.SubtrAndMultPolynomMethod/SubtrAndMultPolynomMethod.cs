// 12. Extend the program to support also subtraction and multiplication of polynomials.

using System;

class SubtrAndMultPolynomMethod
{
    static void Main()
    {
        decimal[] firstpolinom = { 4, -1 };
        Console.Write("First polinom:                 ");
        PrintPolynomial(firstpolinom);

        decimal[] secondpolinom = { 9, -4, 5 };
        Console.Write("Second polinom:                ");
        PrintPolynomial(secondpolinom);

        int maxLenght = 0;
        if (firstpolinom.Length > secondpolinom.Length)
        {
            maxLenght = firstpolinom.Length;
        }
        else
        {
            maxLenght = secondpolinom.Length;
        }

        decimal[] result = new decimal[maxLenght];
        Console.WriteLine();

        Sum(firstpolinom, secondpolinom, result);

        Console.WriteLine("-----------------------------------------------");
        Console.Write("Sum:                           ");
        PrintPolynomial(result);

        SubtractPolynomials(firstpolinom, secondpolinom, result);

        Console.WriteLine("-----------------------------------------------");
        Console.Write("Substraction:                  ");
        PrintPolynomial(result);

        decimal[] multiply = new decimal[firstpolinom.Length + secondpolinom.Length];

        MultiplyPolynomials(firstpolinom, secondpolinom, multiply);
        
        Console.WriteLine("-----------------------------------------------");
        Console.Write("Multiplication:                ");
        PrintPolynomial(multiply);
    }

    /// <summary>
    /// Prints polynoms
    /// </summary>
    /// <param name="polynom">Polynom as array</param>
    static void PrintPolynomial(decimal[] polynomial)
    {
        for (int i = polynomial.Length - 1; i >= 0; i--)
        {
            if (polynomial[i] != 0 && i != 0)
            {
                if (polynomial[i - 1] >= 0)
                {
                    Console.Write("{1}x^{0} +", i, polynomial[i]);
                }
                else
                {
                    Console.Write("{1}x^{0} ", i, polynomial[i]);
                }
            }
            else if (i == 0)
            {
                Console.Write("{0}", polynomial[i]);
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
    static void Sum(decimal[] firstPolynomial, decimal[] secondPolynomial, decimal[] result)
    {
        int minLenght = 0;
        int smallerPolynomial = 0;

        if (firstPolynomial.Length > secondPolynomial.Length)
        {
            minLenght = secondPolynomial.Length;
            smallerPolynomial = 2;
        }
        else
        {
            minLenght = firstPolynomial.Length;
            smallerPolynomial = 1;
        }
        for (int i = 0; i < minLenght; i++)
        {
            result[i] = firstPolynomial[i] + secondPolynomial[i];
        }
        for (int i = minLenght; i < result.Length; i++)
        {
            if (smallerPolynomial == 1)
            {
                result[i] = secondPolynomial[i];
            }
            else
            {
                result[i] = firstPolynomial[i];
            }
        }
    }

    /// <summary>
    /// Subtract two polynoms
    /// </summary>
    /// <param name="firstPolynom">First Polynom</param>
    /// <param name="secondPolynom">Second Polynom</param>
    /// <param name="result">Subtract of two polynoms as array</param>
    static void SubtractPolynomials(decimal[] firstPolynomial, decimal[] secondPolynomial, decimal[] result)
    {
        int minLenght = 0;
        int smallerPolynomial = 0;

        if (firstPolynomial.Length > secondPolynomial.Length)
        {
            minLenght = secondPolynomial.Length;
            smallerPolynomial = 2;
        }
        else
        {
            minLenght = firstPolynomial.Length;
            smallerPolynomial = 1;
        }

        for (int i = 0; i < minLenght; i++)
        {
            result[i] = firstPolynomial[i] - secondPolynomial[i];
        }

        for (int i = minLenght; i < result.Length; i++)
        {
            if (smallerPolynomial == 1)
            {
                result[i] = secondPolynomial[i];
            }
            else
            {
                result[i] = firstPolynomial[i];
            }
        }
    }

    /// <summary>
    /// Multiply two polynoms
    /// </summary>
    /// <param name="firstPolynom">First Polynom</param>
    /// <param name="secondPolynom">Second Polynom</param>
    /// <param name="result">Multiply of two polynoms as array</param>
    static void MultiplyPolynomials(decimal[] firstPolynomial, decimal[] secondPolynomial, decimal[] result)
    {
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = 0;
        }

        for (int i = 0; i < firstPolynomial.Length; i++)
        {
            for (int j = 0; j < secondPolynomial.Length; j++)
            {
                int position = i + j;
                result[position] += (firstPolynomial[i] * secondPolynomial[j]);
            }
        }
    }
}

/** Console output:
First polinom:                 -1x^1 +4
Second polinom:                5x^2 -4x^1 +9

-----------------------------------------------
Sum:                           5x^2 -5x^1 +13
-----------------------------------------------
Substraction:                  5x^2 +3x^1 -5
-----------------------------------------------
Multiplication:                -5x^3 +24x^2 -25x^1 +36
Press any key to continue . . .
**/