// 13. Write a program that reads a list of words from a file words.txt
// and finds how many times each of the words is contained in another file test.txt.
// The result should be written in the file result.txt
// and the words should be sorted by the number of their occurrences in descending order.
// Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

class WordsCounter
{
    // Global variables
    static string wordsListName = @"..\..\words.txt";
    static string testFileName = @"..\..\test.txt";
    static string resultFileName = @"..\..\result.txt";

    static void Main()
    {
        // Reads file with words to search
        string[] wordsList = File.ReadAllLines(wordsListName);
        
        // Define dictionary
        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        // Open test.txt for reading
        using (StreamReader testFile = new StreamReader(testFileName))
        {
            string line;
            
            // Reads test.txt
            while ((line = testFile.ReadLine()) != null)
            {
                for (int i = 0; i < wordsList.Length; i++)
                {
                    string regex = @"\b" + wordsList[i] + @"\b";
                    
                    MatchCollection matches = Regex.Matches(line, regex, RegexOptions.IgnoreCase);
                    
                    if (dictionary.ContainsKey(wordsList[i]))
                    {
                        dictionary[wordsList[i]] += matches.Count;
                    }
                    
                    else
                    {
                        dictionary.Add(wordsList[i], matches.Count);
                    }
                }
            }
        }

        // Open result.txt for write
        using (StreamWriter resulFile = new StreamWriter(resultFileName))
        {
            resulFile.WriteLine(" {0}   | {1}", "Words".PadRight(15, ' '), "Counts".PadLeft(3, ' '));
            resulFile.WriteLine(new string('=', 30));

            foreach (var wordCount in dictionary.OrderByDescending(key => key.Value))
            {
                resulFile.WriteLine("[{0}] => {1}", wordCount.Key.ToString().PadRight(15, ' '), wordCount.Value.ToString().PadLeft(3, ' '));
            }
            Console.WriteLine("Word are counted!");
        }
    }
}

