// 03. Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class TwoCharArrays
{
    static void Main()
    {
        // Read first char array
        Console.Write("Enter first char array: ");
        string arrayOne = Console.ReadLine();
        
        // Read second char array
        Console.Write("Enter secondt char array: ");
        string arrayTwo = Console.ReadLine();

        // Define and calculate the minimal length of arrays
        int minLenght = Math.Min(arrayOne.Length, arrayTwo.Length);

        // Define earlier counter
        int whoIsEarlier = 0;

        // Loop from 0 to minimal length of arrays
        for (int element = 0; element < minLenght; element++)
        {

            // Check element by element of both arrays
            if (arrayOne[element] < arrayTwo[element])
            {
                // Earlier array is array one
                whoIsEarlier = 1;
                break;
            }
            else if (arrayOne[element] > arrayTwo[element])
            {
                // Earlier array is array two
                whoIsEarlier = 2;
                break;
            }
        }

        // Print results of depend of who is the earlier array.
        if (whoIsEarlier == 1)
        {
            Console.WriteLine("Array one is earlier.");
        }
        else if (whoIsEarlier == 2)
        {
            Console.WriteLine("Array two is earlier.");
        }
        else
        {
            Console.WriteLine("Array one and array two are equal.");
        }

    }
}
