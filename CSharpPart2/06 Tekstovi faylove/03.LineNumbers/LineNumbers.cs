// 03. Write a program that reads a text file and inserts line numbers in front of each of its lines.
// The result should be written to another text file.

using System;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        // Sets the path to input and output files.
        string inputFileName = @"../../input.txt";
        string outputFileName = @"../../output.txt";

        // Declares instances for input and output files.
        StreamReader inputFile = new StreamReader(inputFileName);
        StreamWriter outputFile = new StreamWriter(outputFileName);

        using (inputFile)
        {
            using (outputFile)
            {
                int lineNumber = 1;
                
                // Reads first line
                string line = inputFile.ReadLine();

                while (line != null)
                {
                    // Write line number and line
                    outputFile.Write("[{0}] ", lineNumber);
                    outputFile.WriteLine(line);

                    // Reads next line and increase the counter
                    line = inputFile.ReadLine();
                    lineNumber++;
                }
            }
        }

        Console.WriteLine("New file created!");
    }
}