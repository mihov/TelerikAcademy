// 24. Write a program that reads a list of words, separated by spaces
// and prints the list in an alphabetical order

using System;
using System.Collections.Generic;
using System.Linq;

class OrderWords
{
    static void Main()
    {
        // Reads and split the input text 
        Console.WriteLine("Enter/paste a text.");
        string[] inputText = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Sort
        Array.Sort(inputText);

        // Prints the result
        Console.WriteLine("\nSorted words are:");
        foreach (string word in inputText)
        {
            Console.WriteLine(word);
        }
    }
}

/** Console output:
Enter/paste a text.
JustCode is unobtrusive and integrates seamlessly with your natural work-flow

Sorted words are:
and
integrates
is
JustCode
natural
seamlessly
unobtrusive
with
work-flow
your
Press any key to continue . . .
**/