// 09. We are given a string containing a list of forbidden words
// and a text containing some of these words.
// Write a program that replaces the forbidden words with asterisks.

using System;
using System.Text.RegularExpressions;

class ForbiddenWords
{
    static void Main()
    {
        // Reads the text
        Console.WriteLine("Enter a text:");
        String theText = Console.ReadLine();

        // Reads forbidden words as array
        Console.Write("\nEnter forbidden words (separeted ','): ");
        string[] forbiddenWords = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        // Loop for all forbidden words
        for (int forbiddenWordsCounter = 0; forbiddenWordsCounter < forbiddenWords.Length; forbiddenWordsCounter++)
        {
            // Prepare current forbidden word and asterisks
            string forbiddenWord = forbiddenWords[forbiddenWordsCounter];
            string asterisks = new string('*', forbiddenWord.Length);

            // Do replace
            theText = Regex.Replace(theText, forbiddenWord, asterisks);
        }

        // Print the result
        Console.WriteLine("\nCensored Result text:\n{0}", theText);
    }
}

/** Console output:
Enter a text:
Microsoft announced its next generation PHP compiler today. It is based on .NET
Framework 4.0 and is implemented as a dynamic language in CLR.

Enter forbidden words (separeted ','): PHP, CLR, Microsoft

Censored Result text:
********* announced its next generation *** compiler today. It is based on .NET
Framework 4.0 and is implemented as a dynamic language in ***.
Press any key to continue . . .
**/