// 5.2. Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it.
// Use a sequence of if statements.

using System;

class Sign
{
    static void Main()
    {
        // Read the values from console
        Console.WriteLine("Enter three numbers, to see sign of their product.");
        Console.Write("[1] = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("[2] = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("[3] = ");
        int c = int.Parse(Console.ReadLine());

        // Set somes variables
        bool signA = false;// true -> +   false -> -
        bool signB = false;
        bool signC = false;

        // Extract the signs of variables
        if (a > 0)
        {
            signA = true;
        }
        
        if (b > 0)
        {
            signB = true;
        }

        if (c > 0)
        {
            signC = true;
        }

        // Compare the resuls
        bool theResult = !(!(signA ^ signB) ^ signC); 

        // Print the result
        if (theResult)
        {
            Console.WriteLine("The sign of product is +.");
        }
        else
        {
            Console.WriteLine("The sign of product is -.");
        }
    }
}

/** Console Output:
Enter three numbers, to see sign of their product.
[1] = -6
[2] = 4
[3] = 3
The sign of product is -.
Press any key to continue . . .
 **/
