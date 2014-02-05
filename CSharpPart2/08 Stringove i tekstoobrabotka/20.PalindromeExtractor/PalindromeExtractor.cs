// 20. Write a program that extracts from a given text all palindromes,
// e.g. "ABBA", "lamal", "exe".

using System;
using System.Text.RegularExpressions;

class PalindromeExtractor
{
    static void Main()
    {
        // Reads input text
        Console.WriteLine("Enter/paste a text which content palindromes.");
        string inputText = Console.ReadLine();

        // Define the pattern for all words
        string pattern = @"\b\w+\b";

        // Collect maches
        MatchCollection allWords = Regex.Matches(inputText, pattern);


        // Print the result
        Console.WriteLine("\nCollected palindromes:");
        foreach (Match word in allWords)
        {
            // Check is current word plindrom
            if (isPalindrome(word))
            {
                // Prints plindrom
                Console.WriteLine(word);
            }
        }

    }

    // Method checks is word plindrom
    static bool isPalindrome(Match word)
    {
        string wordString = word.ToString();
        
        // Loop for all chars in word
        for (int i = 0; i < wordString.Length; i++)
        {
            // Compare oposite chars in word
            if (wordString[i] != wordString[wordString.Length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}

/** Console output:
Enter/paste a text which content palindromes.
Palindrome 17: level Palindrome 18: racecar Palindrome 19: radar Palindrome 20:
redder Palindrome 21: bob Palindrome 22: pop Palindrome 23: tot Palindrome 24: r
efer Palindrome 25: reviver Palindrome 26: rotator Palindrome 27: rotavator

Collected palindromes:
level
racecar
radar
redder
bob
22
pop
tot
refer
reviver
rotator
rotavator
Press any key to continue . . .
**/