// 07. Write a method that reverses the digits of given decimal number. Example: 256 --> 652


using System;

class DigitReverserMethod
{
    static void Main()
    {
        Console.Write("Enter an integer value: ");

        // Using the method DigitReverse.
        Console.WriteLine("Reversed value is: {0}", DigitReverser(decimal.Parse(Console.ReadLine())));
    }

    /// <summary>
    /// Return reversed decimal value.
    /// </summary>
    /// <param name="valueToReverse">Decimal value.</param>
    /// <returns>Reversed decimal value.</returns>
    static decimal DigitReverser(decimal valueToReverse)
    {
        string temp = "";

        char sign = '+';
        int endOfString = 0;

        // Get the negative sign if it is
        if (valueToReverse < 0)
        {
            sign = '-';
            endOfString = 1;
        }

        // Loop for all items to get them reversed.
        for (int counter = valueToReverse.ToString().Length - 1; counter >= endOfString; counter--)
        {
            temp += valueToReverse.ToString()[counter];
        }
        
        // Return sign and reversed value.
        return decimal.Parse(sign + temp);
    }
}

/** Console output:
Enter an integer value: 123456
Reversed value is: 654321
Press any key to continue . . .
 * 
 * 
Enter an integer value: -123456
Reversed value is: -654321
Press any key to continue . . .
 * 
 *
Enter an integer value: 123.45
Reversed value is: 54.321
Press any key to continue . . .
 * 
 * 
Enter an integer value: -987.654
Reversed value is: -456.789
Press any key to continue . . .
 **/
