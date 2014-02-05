// 14. Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
// Use variable number of arguments.

using System;

class VariableNumberOfArguments
{
    static void Main()
    {
        int[] testArray = { 1, 2, 3, 4, 5 };
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
    /// <param name="sequence"></param>
    /// <returns></returns>
    static int Product(params int[] sequence)
    {
        int product = 1;
        for (int i = 0; i < sequence.Length; i++)
        {
            product *= sequence[i];
        }
        return product;
    }

    /// <summary>
    /// Sum
    /// </summary>
    /// <param name="sequence"></param>
    /// <returns></returns>
    static int Sum(params int[] sequence)
    {
        int sum = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }
        return sum;
    }

    /// <summary>
    /// Average
    /// </summary>
    /// <param name="sequence"></param>
    /// <returns></returns>
    static double Average(params int[] sequence)
    {
        double sum = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }

        return sum / sequence.Length;
    }

    /// <summary>
    /// Max
    /// </summary>
    /// <param name="sequence"></param>
    /// <returns></returns>
    static int Max(params int[] sequence)
    {
        int bestMax = int.MinValue;
        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] > bestMax)
            {
                bestMax = sequence[i];
            }
        }
        return bestMax;
    }

    /// <summary>
    /// Min
    /// </summary>
    /// <param name="sequence"></param>
    /// <returns></returns>
    static int Min(params int[] sequence)
    {
        int bestMin = int.MaxValue;
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
