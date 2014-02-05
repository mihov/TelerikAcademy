// 09. Write a program that deletes from given text file all odd lines.
// The result should be in the same file.

using System;
using System.Collections.Generic;
using System.IO;

class DeleteOddLines
{
    static string fileName = @"..\..\test.txt";
    static void Main()
    {
        // Reads all lines
        string[] lines = File.ReadAllLines(fileName);

        // Redy to write
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            for (int currentLine = 0; currentLine < lines.Length; currentLine++)
            {
                if (currentLine % 2 != 0)
                {
                    // Write only even
                    writer.WriteLine(lines[currentLine]);
                }
            }
            Console.WriteLine("Odd lines deleted!");
        }
    }
}
