// 06. Write a program that reads a text file containing a list of strings,
// sorts them and saves them to another text file

using System;
using System.Collections.Generic;
using System.IO;

class SortFile
{
    // Define global variables
    static string fileName = @"..\..\input.txt";
    static string outFileName = @"..\..\out.txt";
    
    static void Main()
    {
        try
        {
            // Define file for reading
            StreamReader file = new StreamReader(fileName);

            // Define List for file lines
            List<string> fileLines = new List<string>();

            // Copy all lines from input file to the List
            using (file)
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    fileLines.Add(line);
                }
            }

            // Sort the list
            fileLines.Sort();

            // Define output file
            StreamWriter outFile = new StreamWriter(outFileName);

            // Copy all lines from list to the output file
            using (outFile)
            {
                for (int lines = 0; lines < fileLines.Count; lines++)
                {
                    outFile.WriteLine(fileLines[lines]);
                }
            }

        }
        catch
        {

            Console.WriteLine("File {0} do not exist!", fileName); ;
        }

        Console.WriteLine("New sorted file created!");
    }
}

/** Input File:
Ivan
Peter
Maria
George
Vasil
Stoian

Ouput File:
George
Ivan
Maria
Peter
Stoian
Vasil
**/