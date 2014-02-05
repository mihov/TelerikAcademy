// 12. Write a program that creates an array containing all letters from the alphabet (A-Z).
// Read a word from the console and print the index of each of its letters in the array.

using System;

class LettersArray
{
    static void Main()
    {
        // Print some information
        Console.WriteLine("Enter some word to convert it.\nEnter empty line for end.");

        // Declare char array alphabetArray
        char[] alphabetArray = new char[27];
        alphabetArray[0] = ' '; // space = 0

        // Fill alphabet array with letters. A = 1, B = 2,...
        for (int position = 1; position < 27; position++)
        {
            alphabetArray[position] = (char)(position + 64);
        }

        while (true)
        {
            Console.Write("\nEnter word: ");
            // Read from console some words
            string theWord = Console.ReadLine();

            // Convert all case to upper 
            theWord = theWord.ToUpper();

            // Start convertion if word is not empty
            if (theWord.Length > 0)
            {
                // Loop for all positions of words
                for (int position = 0; position < theWord.Length; position++)
                {
                    // Find the index and print the result
                    Console.Write((Array.FindIndex(alphabetArray, item => item == theWord[position])).ToString().PadLeft(3, ' '));
                }
                Console.WriteLine();
            }
            else
            {
                // If empty word entered, application  finish.
                Console.WriteLine("Bye.");
                return;
            }
        }
    }
}

/** Console Output:
Enter some word to convert it.
Enter empty line for end.

Enter word: Hello world
  8  5 12 12 15  0 23 15 18 12  4

Enter word: TELERIK ACADEMY
 20  5 12  5 18  9 11  0  1  3  1  4  5 13 25

Enter word: SOFIA
 19 15  6  9  1

Enter word: Sofia
 19 15  6  9  1

Enter word:
Bye.
Press any key to continue . . .
**/
