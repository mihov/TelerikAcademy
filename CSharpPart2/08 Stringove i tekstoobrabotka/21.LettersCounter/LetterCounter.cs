// 21. Write a program that reads a string from the console
// and prints all different letters in the string along with information
// how many times each letter is found. 

using System;
using System.Collections.Generic;
using System.Linq;

class LetterCounter
{
    static void Main()
    {
        // Reads input text
        Console.WriteLine("Enter/paste a text.");
        string inputText = Console.ReadLine();

        // Define dictionary
        Dictionary<char, int> dictionary = new Dictionary<char, int>();

        // Loop for all chars
        for (int i = 0; i < inputText.Length; i++)
        {
            // Add each char into dictionary and increase its counter.
            if (dictionary.ContainsKey(inputText[i]))
            {
                dictionary[inputText[i]]++;
            }
            else
            {
                dictionary.Add(inputText[i], 1);
            }
        }

        // Prints the result ordered by letter.
        foreach (var letter in dictionary.OrderBy(letters => letters.Key))
        {
            Console.WriteLine("[{0}] ==> {1}", letter.Key, letter.Value);
        }

    }
}

/** Console output:
Enter/paste a text.
Palindrome 17: level Palindrome 18: racecar Palindrome 19: radar Palindrome 20:
redder Palindrome 21: bob Palindrome 22: pop Palindrome 23: tot Palindrome 24: r
efer Palindrome 25: reviver Palindrome 26: rotator Palindrome 27: rotavator
[ ] ==> 32
[0] ==> 1
[1] ==> 4
[2] ==> 9
[3] ==> 1
[4] ==> 1
[5] ==> 1
[6] ==> 1
[7] ==> 2
[8] ==> 1
[9] ==> 1
[:] ==> 11
[P] ==> 11
[a] ==> 18
[b] ==> 2
[c] ==> 2
[d] ==> 14
[e] ==> 20
[f] ==> 1
[i] ==> 12
[l] ==> 13
[m] ==> 11
[n] ==> 11
[o] ==> 18
[p] ==> 2
[r] ==> 25
[t] ==> 6
[v] ==> 4
Press any key to continue . . .
**/