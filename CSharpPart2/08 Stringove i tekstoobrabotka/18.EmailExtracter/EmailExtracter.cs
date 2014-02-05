// 18. Write a program for extracting all email addresses from given text.
// All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Text.RegularExpressions;

class EmailExtracter
{
    static void Main()
    {
        // Reads input text
        Console.WriteLine("Enter/paste a text which content emails.");
        string inputText = Console.ReadLine();

        // Define the pattern
        string pattern = @"[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-zA-Z]{2,4}";

        // Collect maches
        MatchCollection emailCollection = Regex.Matches(inputText, pattern);

        // Print the result
        Console.WriteLine("\nEmail addresses:");
        foreach (var email in emailCollection)
        {
            Console.WriteLine(email);
        }
    }
}

/** Console output:
Enter/paste a text which content emails.
За връзка 0899 94 55 91 (02) 870 08 28 office@biodarove.com biodarove.com Адрес:
 гр. София 1729, ж.к. Младост 1А, бул. "Ал. Малинов" 31 (Сватбен мол "Булевард",
 етаж 2) Имейл: academy@telerik.com Форум: forums.academy.telerik.com GPS коорди
нати: 42.65091

Email addresses:
office@biodarove.com
academy@telerik.com
Press any key to continue . . .
**/