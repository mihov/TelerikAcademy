// 5.10. Write a program that applies bonus scores to given scores in the range [1..9].
// The program reads a digit as an input.
// If the digit is between 1 and 3, the program multiplies it by 10;
// if it is between 4 and 6, multiplies it by 100;
// if it is between 7 and 9, multiplies it by 1000.
// If it is zero or if the value is not a digit, the program must report an error.
// Use a switch statement and at the end print the calculated new value in the console.

using System;

class BonusScores
{
    static void Main()
    {
        Console.Write("Enter your scores: ");
        int scores;
        if (int.TryParse(Console.ReadLine(), out scores)) // Read the scores and try to parse
        {
            switch (scores)
            {
                case 1:                     // if it is between 1 and 3, multiplies it by 10
                case 2:
                case 3:
                    scores *= 10;
                    break;
                case 4:                     // if it is between 4 and 6, multiplies it by 100
                case 5:
                case 6:
                    scores *= 100;
                    break;
                case 7:                     // if it is between 7 and 9, multiplies it by 1000.
                case 8:
                case 9:
                    scores *= 1000;
                    break;
                default:                    // if it is not in rangr 1..9 prints error message
                    scores = 0;
                    Console.WriteLine("You entered a wrong scores!");
                    break;
            }
            Console.WriteLine("Your new scores = {0}", scores); // Prins ne scores on the console
        }
        else
        {
            Console.WriteLine("Unable to convert!");
        }
    }
}

/** Console output:
Enter your scores: 7
Your new scores = 7000
Press any key to continue . . .
 * 

**/