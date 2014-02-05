// 03. Write a program to check if in a given expression the brackets are put correctly.
//      Example of correct expression: ((a+b)/5-d).
//      Example of incorrect expression: )(a+b)).

using System;

class Brackets
{
    static void Main()
    {
        Console.Write("Enter an expression: ");

        // Reads expression
        char[] expression = Console.ReadLine().ToCharArray();

        int bracketsCounter = 0;

        // Loop for all expression elements
        for (int counter = 0; counter < expression.Length; counter++)
        {
            // Counts all open Brackets
            if (expression[counter] == '(')
            {
                bracketsCounter++;
            }

            // Count all close Brackets
            else if (expression[counter] == ')')
            {
                bracketsCounter--;
            }
        }

        // Prints result
        Console.Write("Expression is ");

        if (bracketsCounter == 0)
        {
            Console.WriteLine("correct!");
        }
        else
        {
            Console.WriteLine("incorrect!");
        }

    }
}

/** Console output:
Enter an expression: ((a+b)/5-d)
Expression is correct!
Press any key to continue . . .
 * 
Enter an expression: )(a+b))
Expression is incorrect!
Press any key to continue . . .

**/