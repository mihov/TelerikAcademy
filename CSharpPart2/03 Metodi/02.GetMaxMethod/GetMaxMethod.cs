// 02. Write a method GetMax() with two parameters that returns the bigger of two integers.
// Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().


using System;

    class GetMaxMethod
    {
        static void Main()
        {
            Console.WriteLine("Enter three integer values.");

            // Reads value one.
            Console.Write("[1] = ");
            int valueOne = int.Parse(Console.ReadLine());

            // Reads value two.
            Console.Write("[2] = ");
            int valueTwo = int.Parse(Console.ReadLine());

            // Reads value three.
            Console.Write("[3] = ");
            int valueThree = int.Parse(Console.ReadLine());

            // Prints GetMax of GetMax 
            Console.WriteLine("\nBiggest value of {0}, {1} and {2} is {3}.", valueOne, valueTwo, valueThree, GetMax(GetMax(valueOne, valueTwo), valueThree));
        }

        /// <summary>
        /// Return maximal value of two integers.
        /// </summary>
        /// <param name="value1">First integer value.</param>
        /// <param name="value2">Second integer value.</param>
        /// <returns>Maximal value of two integers.</returns>
        static int GetMax(int value1, int value2)
        {
            // Compare value one and value two.
            if (value1 > value2)
            {
                // Value one is bigger.
                return value1;
            }

            // Value two is bigger or equal.
            return value2;
        }
    }

/** Console output:
Enter three integer values.
[1] = 10
[2] = 5
[3] = 1

Biggest value of 10, 5 and 1 is 10.
Press any key to continue . . .
**/