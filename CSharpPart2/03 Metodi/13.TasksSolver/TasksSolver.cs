// 13. Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//        Create appropriate methods.
//        Provide a simple text-based menu for the user to choose which task to solve.
//        Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

using System;

class TasksSolver
{
    static void Main()
    {
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("|                    TASK SOLVER                     |");
        Console.WriteLine("|                    Select task                     |");
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("| 1. Reverses the digits of a number                 |");
        Console.WriteLine("| 2. Calculates the average of a sequence of integers|");
        Console.WriteLine("| 3. Solves a linear equation a * x + b = 0          |");
        Console.WriteLine("| 4. Exit                                            |");
        Console.Write("------------------------------------------------------");

        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine("| 1. Reverses the digits of a number                 |");
                Console.WriteLine("------------------------------------------------------");
                ReverseInput();
                break;
            case "2":

                Console.WriteLine("| 2. Calculates the average of a sequence of integers|");
                Console.WriteLine("------------------------------------------------------");
                AverageInput();
                break;
            case "3":

                Console.WriteLine("| 3. Solves a linear equation a * x + b = 0          |");
                Console.WriteLine("------------------------------------------------------");
                Equation();
                break;
            case "4":
                return;
            default:

                Console.WriteLine("|     Invalid Input - Please Select 1, 2, 3 or 4.    |");
                Console.WriteLine("------------------------------------------------------");
                break;
        }
        Console.ReadKey();
        Console.Clear();
        Main();
    }

    /// <summary>
    /// Calculate equation a * x + b = 0
    /// </summary>
    static void Equation()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("A must not be equal to Zero!");
        }
        else
        {
            Console.WriteLine("Equation result is: {0}", (double)-b / a);
        }
    }

    /// <summary>
    /// Average
    /// </summary>
    static void AverageInput()
    {
        Console.Write("Enter the size of the sequence: ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("The sequence must have atleast 1 or more elements!");
            return;
        }
        int[] sequence = new int[n];
        Console.WriteLine("Enter Elements.");
        for (int i = 0; i < sequence.Length; i++)
        {
            Console.Write("[{0}]: ", i + 1);
            sequence[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The Average is: {0}", CalcAverage(sequence));
    }

    /// <summary>
    /// Calculate Average
    /// </summary>
    /// <param name="sequence"></param>
    /// <returns></returns>
    static double CalcAverage(int[] sequence)
    {
        double sum = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }

        return sum / sequence.Length;
    }

    /// <summary>
    /// Reverse
    /// </summary>
    static void ReverseInput()
    {
        Console.Write("Enter N: ");
        string number = Console.ReadLine();
        if (int.Parse(number) > 0)
        {
            Console.WriteLine("The Reversed N is: {0}", Reverse(number));
        }
        else
        {
            Console.WriteLine("The number must be non-negative");
        }
    }

    /// <summary>
    /// Do Reverse
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    static int Reverse(string number)
    {
        int[] digits = new int[number.Length];
        int numberInt = int.Parse(number);
        int i = 0;
        while (numberInt > 0)
        {
            int lastDigit = numberInt % 10;
            numberInt /= 10;
            digits[i] = lastDigit;
            i++;
        }

        int finalNumber = 0;
        for (int j = 0; j < digits.Length; j++)
        {
            finalNumber = finalNumber * 10 + digits[j];
        }
        return finalNumber;
    }
}

/** Console output:
------------------------------------------------------
|                    TASK SOLVER                     |
|                    Select task                     |
------------------------------------------------------
| 1. Reverses the digits of a number                 |
| 2. Calculates the average of a sequence of integers|
| 3. Solves a linear equation a * x + b = 0          |
| 4. Exit                                            |
------------------------------------------------------2
| 2. Calculates the average of a sequence of integers|
------------------------------------------------------
Enter the size of the sequence: 5
Enter Elements.
[1]: 2
[2]: 3
[3]: 4
[4]: 5
[5]: 6
The Average is: 4
**/