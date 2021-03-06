﻿/*
 * 05. Define a class BitArray64 to hold 64 bit values inside an ulong value. 
 * Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
 */
namespace ProblemBitArray64
{
    using System;

    class MainTest
    {
        static void Main()
        {
            BitArray64 num1 = new BitArray64(1024);
            BitArray64 num2 = new BitArray64(byte.MaxValue);

            Console.WriteLine("Num1: {0}", num1);
            Console.WriteLine("Num2: {0}", num2);

            Console.WriteLine("Num1 == Num2 ==> {0}", num1 == num2);

            Console.WriteLine("Num1[ 9] ==> {0}", num1[9]);
            Console.WriteLine("Num1[10] ==> {0}", num1[10]);
            Console.WriteLine("Num1[11] ==> {0}", num1[11]);

        }
    }
}
