// 11. Write a program that deletes from a text file all words that start with the prefix "test".
// Words contain only the symbols 0...9, a...z, A…Z, _.

// !!! First open file test.txt to see it before actions!!!

using System;
using System.IO;
using System.Text.RegularExpressions;

class DeleteWithPrefix
{
    // Set global values
    static string prefix = @"\b(test\w*)\b";
    static string  fileName = @"..\..\test.txt";
    
    static void Main()
    {
        // Reads all text
        string fileContent = File.ReadAllText(fileName);
        
        // Write all new text to same file
        File.WriteAllText(fileName, Regex.Replace(fileContent, prefix, String.Empty));
        
        Console.WriteLine("Words with prefix {0} deleted!", "test");
    }
}