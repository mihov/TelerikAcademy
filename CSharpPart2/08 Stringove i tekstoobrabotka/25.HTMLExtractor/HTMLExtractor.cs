// 25. Write a program that extracts from given HTML file its title (if available),
// and its body text without the HTML tags. 
using System;
using System.IO;
using System.Text.RegularExpressions;

class HTMLExtractor
{
    static void Main()
    {
        // Open and read file
        string htmlText = File.ReadAllText(@"..\..\test.html");

        // Define pattern
        string pattern = "(?<=^|>)[^><]+?(?=<|$)";

        // Match pattern
        MatchCollection extractedText = Regex.Matches(htmlText, pattern);

        // Print the result
        Console.WriteLine("Extracted text:");
        foreach (var value in extractedText)
        {
            Console.WriteLine(value);
        }
    }
}

/** Console output:
Extracted text:


News


Telerik
    Academy
aims to provide free real-world practical
    training for young people who want to turn into
    skillful .NET software engineers.


Press any key to continue . . .
**/