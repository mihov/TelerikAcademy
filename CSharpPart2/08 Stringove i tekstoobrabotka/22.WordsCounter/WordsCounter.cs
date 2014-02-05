// 22. Write a program that reads a string from the console
// and lists all different words in the string along with information
// how many times each word is found.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

class WordsCounter
{
    static void Main()
    {
        // Reads input text
        Console.WriteLine("Enter/paste a text.");
        string inputText = Console.ReadLine();

        // Define the pattern for all words
        string pattern = @"\b\w+\b";

        // Collect maches
        MatchCollection allWords = Regex.Matches(inputText, pattern);
        
        // Define dictionary
        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        // Loop for all words
        foreach (Match word in allWords)
        {
            // Add each word into dictionary and increase its counter.
            if (dictionary.ContainsKey(word.ToString()))
            {
                dictionary[word.ToString()] += 1;
            }
            else
            {
                dictionary.Add(word.ToString(), 1);
            }
        }

        // Sort and print the result
        foreach (var word in dictionary.OrderByDescending(wordList => wordList.Key))
        {
            Console.WriteLine("[{0}] - {1}", word.Key, word.Value);
        }
    }
}

/** Console output:
Enter/paste a text.
JustCode is a Visual Studio extension that provides on-the-spot .NET code analys
is and error checking, smart navigation and refactoring. So you code faster. Jus
tCode is unobtrusive and integrates seamlessly with your natural work-flow. Quic
k hints, code
[your] - 1
[you] - 1
[work] - 1
[with] - 1
[Visual] - 1
[unobtrusive] - 1
[the] - 1
[that] - 1
[Studio] - 1
[spot] - 1
[So] - 1
[smart] - 1
[seamlessly] - 1
[refactoring] - 1
[Quick] - 1
[provides] - 1
[on] - 1
[NET] - 1
[navigation] - 1
[natural] - 1
[JustCode] - 2
[is] - 2
[integrates] - 1
[hints] - 1
[flow] - 1
[faster] - 1
[extension] - 1
[error] - 1
[code] - 3
[checking] - 1
[and] - 3
[analysis] - 1
[a] - 1
Press any key to continue . . .
**/