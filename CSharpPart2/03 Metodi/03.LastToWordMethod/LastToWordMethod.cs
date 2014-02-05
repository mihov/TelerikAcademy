// 03. Write a method that returns the last digit of given integer as an English word.
// Examples: 512 --> "two", 1024 --> "four", 12309 --> "nine".


using System;

class LastToWordMethod
{
    static void Main()
    {
        // Define random object
        Random rnd = new Random();

        // Loop for a few random numbers.
        for (int count = 0; count < 5; count++)
        {
            // Get random number
            int randomInt = rnd.Next(1000, 9999);

            // Prints the result
            Console.WriteLine("{0} --> {1}", randomInt, LastToWord(randomInt));
        }
    }

    /// <summary>
    /// Returns the last digit of given integer as an English word. 
    /// </summary>
    /// <param name="someInt">Some integer.</param>
    /// <returns>Returns the last digit of given integer as an English word.</returns>
    static string LastToWord(int someInt)
    {
        // Get last digit
        switch (someInt % 10)
        {
            // Compare it and return it as English word.
            case 1:
                return "one";
            case 2:
                return "two";
            case 3:
                return "three";
            case 4:
                return "four";
            case 5:
                return "five";
            case 6:
                return "six";
            case 7:
                return "seven";
            case 8:
                return "eight";
            case 9:
                return "nine";
            default:
                return "zero";
        }
    }
}

/** Console output:
9838 --> eight
2383 --> three
5237 --> seven
8683 --> three
6374 --> four
Press any key to continue . . .
 **/
