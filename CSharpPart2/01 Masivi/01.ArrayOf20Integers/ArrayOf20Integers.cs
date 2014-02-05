// 01. Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. 
//    Print the obtained array on the console.


using System;

class ArrayOf20Integers
{
    static void Main()
    {
        // Declaring array of integers
        int[] intArray = new int[20];

        // Loop from 0 to Array.Length - 1
        for (int index = 0; index < intArray.Length; index++)
        {
            // Calculate each element 
            intArray[index] = index * 5;
        }

        // Print Title
        Console.WriteLine("Index => Value");

        // Loop from 0 to Array.Length - 1 
        for (int index = 0; index < intArray.Length; index++)
        {
            // Print index and array's elements on the console.
            Console.WriteLine("{0} -> {1}", index.ToString().PadLeft(5, ' '), intArray[index].ToString().PadLeft(5, ' '));
        }

    }
}

/** Console output:
   Index => Value
    0 ->     0
    1 ->     5
    2 ->    10
    3 ->    15
    4 ->    20
    5 ->    25
    6 ->    30
    7 ->    35
    8 ->    40
    9 ->    45
   10 ->    50
   11 ->    55
   12 ->    60
   13 ->    65
   14 ->    70
   15 ->    75
   16 ->    80
   17 ->    85
   18 ->    90
   19 ->    95
Press any key to continue . . .
 **/

