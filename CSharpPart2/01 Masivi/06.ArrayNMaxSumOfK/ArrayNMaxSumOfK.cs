// 06. Write a program that reads two integer numbers N and K
// and an array of N elements from the console.
// Find in the array those K elements that have maximal sum.

using System;

class ArrayNMaxSumOfK
{
    static void Main()
    {
        // Read lenght of array
        Console.Write("Enter integer value for N: ");
        int arrayNLenght;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out arrayNLenght))
            {
                break;
            }
            else
            {
                Console.Write("Unable to convert. Try again. Value for N: ");
            }
        }

        // Read K
        Console.Write("Enter integer value for K (K < {0}): ", arrayNLenght);
        int arrayKLenght;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out arrayKLenght) && arrayKLenght < arrayNLenght)
            {
                break;
            }
            else
            {
                Console.Write("Unable to convert. Try again. Value for K: ");
            }
        }

        // Read array of N integer elements
        int[] arrayN = new int[arrayNLenght];
        Console.WriteLine("Enter {0} integer values.", arrayNLenght);
        for (int element = 0; element < arrayNLenght; element++)
        {
            Console.Write("[{0}] => ", (element + 1).ToString().PadLeft(3, ' '));
            if (!int.TryParse(Console.ReadLine(), out arrayN[element]))
            {
                element--;
                Console.WriteLine("Try again.");

            }
        }

        // Print the begining of the result
        Console.Write("From array {");
        for (int element = 0; element < arrayNLenght; element++)
        {
            Console.Write(arrayN[element]);
            if (element < arrayNLenght - 1)
            {
                Console.Write(",");
            }

        }
        Console.WriteLine("}.");

        // Search K elements that have maximal sum
        int arrayMaxSum = int.MinValue;
        int startMaxPosition = 0;
        int localSum;

        for (int elementN = 0; elementN <= arrayNLenght - arrayKLenght; elementN++)
        {
            localSum = 0;
            for (int elementK = elementN; elementK < arrayKLenght + elementN; elementK++)
            {
                localSum += arrayN[elementK];
                if (localSum > arrayMaxSum)
                {
                    startMaxPosition = elementN;
                    arrayMaxSum = localSum;
                }
            }

        }

        Console.WriteLine("Maximum sum of {0} elements is {1}, from this sub array:", arrayKLenght, arrayMaxSum);
        // Print array K
        Console.Write('{');
        for (int element = startMaxPosition; element < startMaxPosition + arrayKLenght; element++)
        {
            Console.Write(arrayN[element]);
            if (element < startMaxPosition + arrayKLenght - 1)
            {
                Console.Write(',');
            }
        }
        Console.WriteLine('}');
    }
}
/** Console 
Enter integer value for N: 7
Enter integer value for K (K < 7): 3
Enter 7 integer values.
[  1] => 1
[  2] => 2
[  3] => 3
[  4] => 4
[  5] => 3
[  6] => 2
[  7] => 1
From array {1,2,3,4,3,2,1}.
Maximum sum of 3 elements is 10, from this sub array:
{3,4,3}
Press any key to continue . . .
**/