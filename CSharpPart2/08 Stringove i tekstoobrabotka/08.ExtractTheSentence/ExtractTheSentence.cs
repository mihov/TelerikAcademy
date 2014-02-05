// 08. Write a program that extracts from a given text all sentences containing given word.
// Consider that the sentences are separated by "." and the words – by non-letter symbols.

using System;

class ExtractTheSentence
{
    static void Main()
    {
        // Reads the text, separate it on sentences by "."
        Console.Write("Enter a text: ");
        string[] allText = Console.ReadLine().Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

        // Reads the search word
        Console.Write("\nEnter word to search: ");
        string searcText = Console.ReadLine();

        Console.WriteLine("\nWe found word {0} in:", searcText);

        // Print the result
        for (int sentence = 0; sentence < allText.Length; sentence++)
        {
            if (allText[sentence].IndexOf(" " + searcText, 0) >= 0)
            {
                Console.WriteLine(allText[sentence] + '.');
            }
        }
    }
}

/** Console output:
 * 
Enter a text: We are living in a yellow submarine. We don't have anything else.
Inside the submarine is very tight. So we are drinking all the day. We will move
 out of it in 5 days.

Enter word to search: in

We found word in in:
We are living in a yellow submarine.
 We will move out of it in 5 days.
Press any key to continue . . .
 * 
**/