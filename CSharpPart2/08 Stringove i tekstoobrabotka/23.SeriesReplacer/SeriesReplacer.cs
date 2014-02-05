// 23. Write a program that reads a string from the console
// and replaces all series of consecutive identical letters with a single one.
// Example: "aaaaabbbbbcdddeeeedssaa" --> "abcdedsa".

using System;
using System.Text;

class SeriesReplacer
{
    static void Main()
    {
        // Reads input text
        Console.WriteLine("Enter/paste a text.");
        string inputText = Console.ReadLine();

        char prevCharHolder = Char.MinValue;

        StringBuilder result = new StringBuilder();

        // Loop for all chars in string
        for (int indexer = 0; indexer < inputText.Length; indexer++)
        {
            // Add to result only new chars
            if (inputText[indexer] != prevCharHolder)
            {
                result.Append(inputText[indexer]);
                prevCharHolder = inputText[indexer];
            }
        }
        
        // Prints the result
        Console.WriteLine();
        Console.WriteLine("{0} --> {1}", inputText, result);
    }
}

/** Console output:
Enter/paste a text.
aaaaabbbbbcdddeeeedssaa

aaaaabbbbbcdddeeeedssaa --> abcdedsa
Press any key to continue . . .
**/