// 15. * Modify your last program and try to make it work for any number type,
// not just integer (e.g. decimal, float, byte, etc.).
// Use generic method (read in Internet about generic methods in C#).

using System;

class GenericMethod
{
    static void Main()
    {
        double[] testArray = { 1, 2.4, 3.3, 4.2, 5 };
        Console.WriteLine("Numbers: " + String.Join(", ", testArray));

        Console.WriteLine("\nMin: {0}", Min(testArray));
        Console.WriteLine("\nMax: {0}", Max(testArray));
        Console.WriteLine("\nAverage: {0}", Average(testArray));
        Console.WriteLine("\nSum: {0}", Sum(testArray));
        Console.WriteLine("\nProduct: {0}\n", Product(testArray));
    }

    /// <summary>
    /// Product
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="sequence"></param>
    /// <returns></returns>
    static T Product<T>(params T[] sequence)
    {
        dynamic product = 1;
        for (int i = 0; i < sequence.Length; i++)
        {
            product *= sequence[i];
        }
        return product;
    }

    /// <summary>
    /// Sum
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="sequence"></param>
    /// <returns></returns>
    static T Sum<T>(params T[] sequence)
    {
        dynamic sum = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }
        return sum;
    }

    /// <summary>
    /// Average
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="sequence"></param>
    /// <returns></returns>
    static T Average<T>(params T[] sequence)
    {
        dynamic sum = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }

        return sum / sequence.Length;
    }

    /// <summary>
    /// Max
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="sequence"></param>
    /// <returns></returns>
    static T Max<T>(params T[] sequence)
    {
        dynamic bestMax = int.MinValue;
        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] > bestMax)
            {
                bestMax = sequence[i];
            }
        }
        return bestMax;
    }

    static T Min<T>(params T[] sequence)
    {
        dynamic bestMin = int.MaxValue;
        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] < bestMin)
            {
                bestMin = sequence[i];
            }
        }
        return bestMin;
    }
}

/** Console output:
Numbers: 1, 2.4, 3.3, 4.2, 5

Min: 1

Max: 5

Average: 3.18

Sum: 15.9

Product: 166.32

Press any key to continue . . .
**/