// 10. Write a program that converts a string to a sequence of C# Unicode character literals.
// Use format strings. 

using System;

class StringToUnicodeCharacter
{
    static void Main()
    {
        // Reads the text
        Console.Write("Enter a text: ");
        string theText = Console.ReadLine();

        // Loop for all chars in the test
        for (int everyChar = 0; everyChar < theText.Length; everyChar++)
        {
            // Format each char to unicode
            Console.Write(String.Format("\\u{0:x4}", (int)theText[everyChar]));
        }
        Console.WriteLine();
    }
}

/** Console output:
Enter a text: Hi!
\u0048\u0069\u0021
Press any key to continue . . .
**/