using System;
using System.Collections.Generic;

class ADictionary
{
    static void Main()
    {
        // Reads the search word
        Console.WriteLine("Enter search word: ");
        string searchWord = Console.ReadLine();

        Console.WriteLine("\nEnter/paste the dictionary lines. Ends with empty line.");

        string dictionaryText;

        // Define the dictionary
        Dictionary<string, string> dictionary = new Dictionary<string, string>();


        while (true)
        {
            // Reads current dictionary line
            dictionaryText = Console.ReadLine();
            
            // Check for empty line
            if (dictionaryText.Length > 0)
            {
                // Split the line
                string[] textKeyValue = dictionaryText.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                
                // Add to dictionary
                dictionary.Add(textKeyValue[0].Replace(" ",""), textKeyValue[1]);
            }
            else break;

        }

        string result = string.Empty;

        // If word exist in dictionary, prints the result
        if (dictionary.TryGetValue(searchWord, out result))
        {
            Console.WriteLine("\nResult for {0}:\n{1}", searchWord, result);
        }
        else
        {
            Console.WriteLine("\nNo result for {0}.", searchWord);
        }
    }
}

/** Console output:
Enter search word:
CLR

Enter/paste the dictionary lines.
.NET – platform for applications from Microsoft
CLR – managed execution environment for .NET
namespace – hierarchical organization of classes


Result for CLR:
 managed execution environment for .NET
Press any key to continue . . .
**/
