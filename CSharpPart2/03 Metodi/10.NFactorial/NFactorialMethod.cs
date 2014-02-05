// 10. Write a program to calculate n! for each n in the range [1..100].
// Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 

using System;
using System.Collections.Generic;

class NFactorialMethodMethod
{
    static void Main()
    {
        // Define array for factoriel results
        List<byte> factorial = new List<byte>();

        // Add 1!
        factorial.Add(1);

        // Loop from 1 to 100
        for (int counter = 1; counter <= 100; counter++)
        {
            // Calculate current factorial
            factorial = Multiply(factorial, counter);

            // Prints current factoriel 
            Console.Write("{0, 3}! = ", counter);
            Console.WriteLine(String.Join("", factorial));

        }
    }

    /// <summary>
    /// Return digit at position in given value
    /// </summary>
    /// <param name="value">Given integer value</param>
    /// <param name="position">Given position</param>
    /// <returns>Digit at given position</returns>
    static byte GetValueAtPosition(int value, int position)
    {
        for (int counter = 0; counter < position; counter++)
        {
            value /= 10;
        }
        return (byte)(value % 10);
    }

    /// <summary>
    /// Returns multiply array of digits to integer
    /// </summary>
    /// <param name="multiplicand">Multiplicand array</param>
    /// <param name="multiplier">Multiplie integer</param>
    /// <returns>Multiplied array of digits by integer</returns>
    static List<byte> Multiply(List<byte> multiplicand, int multiplier)
    {
        // Array for result
        List<byte> result = new List<byte>();

        // Reverse for easier work
        multiplicand.Reverse();


        // Counter for multiplier digits
        for (int multiplierCounter = 0; multiplierCounter < multiplier.ToString().Length; multiplierCounter++)
        {
            // Counter for multiplicand elements
            for (int multiplicandCounter = 0; multiplicandCounter < multiplicand.Count; multiplicandCounter++)
            {
                // Add new element if need it
                AddIfNeed(result, multiplicandCounter + multiplierCounter);
                
                // Multiplication
                result[multiplicandCounter + multiplierCounter] += (byte)(multiplicand[multiplicandCounter] * GetValueAtPosition(multiplier, multiplierCounter));

                // Check is current element overflowing the base
                FillUp(result, multiplicandCounter + multiplierCounter);
            }
        }
        // Reverse and return the result
        result.Reverse();
        return result;
    }

    /// <summary>
    /// Add new element if current position need it
    /// </summary>
    /// <param name="array"></param>
    /// <param name="index"></param>
    static void AddIfNeed(List<byte> array, int index)
    {
        if (index >= array.Count)
        {
            array.Add(0);
        }
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
            AddIfNeed(array, position + 1);
            byte temp = array[position];
            array[position] = (byte)(temp % 10);
            array[position + 1] += (byte)(temp / 10);
        }
    }
}

/** Console output:
  1! = 1
  2! = 2
  3! = 6
  4! = 24
  5! = 120
  6! = 720
  7! = 5040
  8! = 40320
  9! = 362880
 10! = 3628800
 * 
 * 
 * 
 95! = 10329978488239059262599702099394727095397746340117372869212250571234293987594703124871765375385424468563282236864226607350415360000000000000000000000
 96! = 991677934870949689209571401541893801158183648651267795444376054838492222809091499987689476037000748982075094738965754305639874560000000000000000000000
 97! = 96192759682482119853328425949563698712343813919172976158104477319333745612481875498805879175589072651261284189679678167647067832320000000000000000000000
 98! = 9426890448883247745626185743057242473809693764078951663494238777294707070023223798882976159207729119823605850588608460429412647567360000000000000000000000
 99! = 933262154439441526816992388562667004907159682643816214685929638952175999932299156089414639761565182862536979208272237582511852109168640000000000000000000000
100! = 93326215443944152681699238856266700490715968264381621468592963895217599993229915608941463976156518286253697920827223758251185210916864000000000000000000000000
Press any key to continue . . .
**/