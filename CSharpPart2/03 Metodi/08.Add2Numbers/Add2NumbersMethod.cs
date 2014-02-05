// 08. Write a method that adds two positive integer numbers
// represented as arrays of digits (each array element arr[i] contains a digit;
// the last digit is kept in arr[0]).
// Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;

class Add2NumbersMethod
{
    static void Main()
    {
        // Define both integers and put some values in them
        //byte[] digit1 = { 9, 9, 9, 9, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        byte[] digit1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        byte[] digit2 = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 2, 3, 4, 5, 6, 7, 8, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

        // Calculate the padding
        int pad = Math.Max(digit1.Length, digit2.Length) + 3;

        // Print both integers
        Console.WriteLine(String.Join("", digit1).PadLeft(pad, ' '));
        Console.WriteLine("+");
        Console.WriteLine(String.Join("", digit2).PadLeft(pad, ' '));
        Console.WriteLine(new string('_', pad + 1));

        // Calculating the sum of both integers and print it
        Console.WriteLine(String.Join("", BigAdd(digit1, digit2)).PadLeft(pad, ' '));
    }

    /// <summary>
    /// Adds two positive integer numbers represented as arrays of digits
    /// </summary>
    /// <param name="digitOne">Digit One</param>
    /// <param name="digitTwo">Digit Two</param>
    /// <returns></returns>
    static List<byte> BigAdd(byte[] digitOne, byte[] digitTwo)
    {
        // Calculate the minimum length of both integers
        int length = Math.Min(digitOne.Length, digitTwo.Length);

        // Copy both arrays in to two lists 
        List<byte> listDigitOne = new List<byte>(digitOne);
        List<byte> listDigitTwo = new List<byte>(digitTwo);

        // Calculate the difference in their lengths.
        int shift = listDigitOne.Count - listDigitTwo.Count;

        // Makes two lists with equal length
        if (shift > 0)
        {
            for (int counter = 1; counter <= shift; counter++)
            {
                // Adds zeros at the beginning of list two.
                listDigitTwo.Add(0);
            }
        }
        else if (shift < 0)
        {
            for (int counter = 1; counter <= Math.Abs(shift); counter++)
            {
                // Adds zeros at the beginning of list one.
                listDigitOne.Add(0);
            }
        }

        // Reversing two arrays for more easy work
        Array.Reverse(digitOne);
        Array.Reverse(digitTwo);

        // Define new list to hold the result.
        List<byte> result = new List<byte>();

        // Adds item to item two arrays.
        for (int counter = 0; counter < length; counter++)
        {
            result.Add(0);
            result[counter] += (byte)(digitOne[counter] + digitTwo[counter]);

            // If current element is bigger than base, recalculate it.
            FillUp(result, counter);
        }

        // Filling the rest of the result list with positions from the bigger array
        if (digitOne.Length > length)
        {
            for (int counter = length; counter < digitOne.Length; counter++)
            {
                result.Add(0);
                result[counter] += digitOne[counter];
                FillUp(result, counter);
            }
        }

        // Filling the rest of the result list with positions from the bigger array
        else if (digitTwo.Length > length)
        {
            for (int counter = length; counter < digitTwo.Length; counter++)
            {
                result.Add(0);
                result[counter] += digitTwo[counter];
                FillUp(result, counter);
            }
        }
        result.Reverse();
        RemovesFirstZero(result);

        // Return the result.
        return result;
    }

    /// <summary>
    /// If current element overflowing the base, shifting and increasing the next element.
    /// </summary>
    /// <param name="array">List of byte</param>
    /// <param name="position">Current position</param>
    static void FillUp(List<byte> array, int position)
    {
        if (array[position] >= 10)
        {
            AddZero(array);

            byte temp = array[position];
            array[position] = (byte)(temp % 10);
            array[position + 1] = (byte)(temp / 10);
        }
    }

    /// <summary>
    /// Add new zero element in list if need it.
    /// </summary>
    /// <param name="array">List of bytes.</param>
    static void AddZero(List<byte> array)
    {
        if (array[array.Count - 1] != 0)
        {
            array.Add(0);
        }
    }

    /// <summary>
    /// Removes zero from the begining
    /// </summary>
    /// <param name="array">List of byte</param>
    static void RemovesFirstZero(List<byte> array)
    {
        if (array[0] == 0 && array.Count > 1)
        {
            // Remove current element if it is zero and not the only one element in list
            array.RemoveAt(0);
            RemovesFirstZero(array);
        }
    }
}

/** Console output:

 9999912345678901234567890
+
 9876543212345678987654321
___________________________
19876455558024580222222211


 ************************************************************** 

        12345678901234567890
+
   9876543212345678987654321
_____________________________
   9876555558024580222222211


**/