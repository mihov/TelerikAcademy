// 02. Write a program that reads two arrays from the console and compares them element by element.

using System;

class CompareArraysElements
{
    static void Main()
    {
        // Print some information message
        Console.Write("How many integer elements do you want to compare? ");
        int elemntsCount;

        // Read elemens cout and try it to parse
        if (int.TryParse(Console.ReadLine(), out elemntsCount))
        {
            // Declare two integer arrays with elemntsCount elemens
            int[] arrayOne = new int[elemntsCount];
            int[] arrayTwo = new int[elemntsCount];

            // Loop for array one and two
            for (int array = 1; array <= 2; array++)
            {
                // Print some information 
                Console.WriteLine("\nEnter values for array {0}, by indexes.", array);

                // Loop for arrays elements from 0 to elemntsCount
                for (int element = 0; element < elemntsCount; element++)
                {
                    Console.Write("{0} : ", element.ToString().PadLeft(3, ' '));
                    int initialValue;

                    // Reads current array element and try it to parse
                    if (int.TryParse(Console.ReadLine(), out initialValue))
                    {
                        switch (array)
                        {

                            // Fill array one
                            case 1:
                                arrayOne[element] = initialValue;
                                break;

                            // Fill array two
                            case 2:
                                arrayTwo[element] = initialValue;
                                break;
                            // No default
                            default:
                                break;
                        }
                    }
                    else
                    {
                        // Error message and preparing for new correct value.
                        Console.WriteLine("You entered uncorrect value! Try again.");
                        element--;
                    }

                }
            }

            // Print the beginning of the result
            Console.WriteLine("\nComparation results:");
            for (int element = 0; element < elemntsCount; element++)
            {
                Console.Write("Element {0} from array 1 is ", element);
                char compareSign;
                if (arrayOne[element] > arrayTwo[element])
                {
                    Console.Write("greater than ");                                 //
                    compareSign = '>';                                              //
                }                                                                   //      Print the middle of the result    
                else if (arrayOne[element] < arrayTwo[element])                     //    
                {                                                                   //    
                    Console.Write("lower   than ");
                    compareSign = '<';
                }
                else
                {
                    Console.Write("equal     to ");
                    compareSign = '=';
                }

                // Print the end of the result
                Console.WriteLine("element {0} from array 2. [{1} {2} {3}]", element, arrayOne[element], compareSign, arrayTwo[element]);
            }
        }
        else
        {
            // Print Error message
            Console.WriteLine("Unable to convert!");
        }
    }
}

/** Console output:
How many integer elements do you want to compare? 3

Enter values for array 1, by indexes.
  0 : 1
  1 : 2
  2 : 3

Enter values for array 2, by indexes.
  0 : 3
  1 : 2
  2 : 1

Comparation results:
Element 0 from array 1 is lower   than element 0 from array 2. [1 < 3]
Element 1 from array 1 is equal     to element 1 from array 2. [2 = 2]
Element 2 from array 1 is greater than element 2 from array 2. [3 > 1]
Press any key to continue . . .
**/
