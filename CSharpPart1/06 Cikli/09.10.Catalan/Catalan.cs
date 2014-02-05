// 09. & 10. Write a program to calculate the Nth Catalan number by given N.


using System;
using System.Numerics;

class Catalan
{
    static void Main()
    {
        Console.Write("Which Catalan number do you want to see? ");
        int numberN;
        if (int.TryParse(Console.ReadLine(), out numberN))      // Read value for first number
        {
            // Calculate N-th Catalian number and print the result
            Console.WriteLine("{0}th Catalan number is {1}.", numberN, factoriel(2*numberN)/(factoriel(numberN+1)*factoriel(numberN)));
        }
    }

    private static BigInteger factoriel(int numberN)    // Create function factoriel
    {
        if (numberN <= 0)
	{
            return 1;
	}
        else
	{
            return numberN * factoriel(numberN - 1);  // Recursive call factoriel
	}
        
        throw new NotImplementedException();
    }
}
/** Console output:
Which Catalan number do you want to see? 25
25th Catalan number is 4861946401452.
Press any key to continue . . .
 **/
