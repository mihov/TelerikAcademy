using System;
using System.Text;
using System.Text.RegularExpressions;

class WordReverser
{
    static void Main()
    {
        // Reads the sentence:
        Console.Write("Enter sentence:  ");
        string sentence = Console.ReadLine();
        
        // define separators
        string wordsRegex = @"[^\s\.!?,;:]+";
        string separatorsRegex = @"[\s\.!?,;:]+";
        
        // Collect words
        MatchCollection words = Regex.Matches(sentence, wordsRegex);
        
        // Collect separators
        MatchCollection separators = Regex.Matches(sentence, separatorsRegex);

        StringBuilder resultSentence = new StringBuilder();

        // Loop for all found words
        for (int i = 0; i < words.Count; i++)
        {
            // Calculate the result
            resultSentence.Append(words[words.Count - 1 - i]);
            resultSentence.Append(separators[i]);
        }

        // Print the result
        Console.WriteLine("Result sentence: {0}", resultSentence.ToString());
    }
}

/** Console output:
Enter sentence:  C# is not C++, not PHP and not Delphi!
Result sentence: Delphi not and PHP, not C++ not is C#!
Press any key to continue . . .
 **/
