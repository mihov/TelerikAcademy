/**02. Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
 * If an invalid number or non-number text is entered, the method should throw an exception. 
 * Using this method write a program that enters 10 numbers:
			a1, a2, … a10, such that 1 < a1 < … < a10 < 100
**/

using System;
using System.Collections.Generic;

class Enter10Numbers
{
    // Define global variables
    static int numbersCount = 10;
    static int start = 1;
    static int end = 100;

    static void Main()
    {
        List<int> numbersArray = new List<int>();

        // Reads numbers
        for (int counter = 0; counter < numbersCount; counter++)
        {
            numbersArray.Add(ReadIntegerNumber(start, end));
        }

        // Printing the collected numbers - Just for test
        foreach (var item in numbersArray)
        {
            Console.WriteLine(item);
        }
    }

    // Read integer numbers in range method
    static int ReadIntegerNumber(int start, int end)
    {

        Console.Write("Enter number in the range [{0}, {1}]: ", start, end);

        int intNumber = 0;
        try
        {
            intNumber = int.Parse(Console.ReadLine());



            if (intNumber <= start || intNumber >= end)
            {
                throw new ArgumentOutOfRangeException();
            }
            Console.WriteLine("Valid number!");
        }

       // Exceptions
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("The number is not in range [{0}, {1}]", start, end);
        }

        catch (FormatException)
        {
            Console.WriteLine("The input is not a number!");
        }

        catch (OverflowException)
        {
            Console.WriteLine("The number is too BIG!");
        }

        catch (ArgumentException)
        {
            Console.WriteLine("You have entered nothing");
        }

        return intNumber;
    }
}

/** Console output:
Enter number in the range [1, 100]: 1
The number is not in range [1, 100]
Enter number in the range [1, 100]: 2
Valid number!
Enter number in the range [1, 100]: 3
Valid number!
Enter number in the range [1, 100]: r
The input is not a number!
Enter number in the range [1, 100]: t
The input is not a number!
Enter number in the range [1, 100]: 2
Valid number!
Enter number in the range [1, 100]: 3444
The number is not in range [1, 100]
Enter number in the range [1, 100]: -88
The number is not in range [1, 100]
Enter number in the range [1, 100]:
The input is not a number!
Enter number in the range [1, 100]:
The input is not a number!
1
2
3
0
0
2
3444
-88
0
0
Press any key to continue . . .
 **/
