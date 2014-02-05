// 02. Write a program that concatenates two text files into another text file.

using System;
using System.IO;

class ConcatenateTwoFiles
{
    static void Main()
    {
        // Sets the path to input files.
        string firstFileName = @"..\..\file1.txt";
        string secondFileName = @"..\..\file2.txt";
        
        // Sets the path to output file.        
        string resultFileName = @"..\..\result.txt";

        // Declares instances for input files.
        StreamReader firstFile = new StreamReader(firstFileName);
        StreamReader secondFile = new StreamReader(secondFileName);

        // Declares instance for output file.        
        StreamWriter resultFile = new StreamWriter(resultFileName);

        using (firstFile)
        {
            using (secondFile)
            {
                using (resultFile)
                {
                    string line;

                    // Print the beginnings of first file.
                    resultFile.WriteLine("File 1:");

                    // Reads first input file line by line and write it to output file.
                    while ((line = firstFile.ReadLine()) != null)
                    {
                        resultFile.WriteLine(line);
                    }
                    
                    resultFile.WriteLine();
                    
                    // Print the beginnings of second file.
                    resultFile.WriteLine("File 2:");

                    // Reads second input file line by line and write it to output file.
                    while ((line = secondFile.ReadLine()) != null)
                    {
                        resultFile.WriteLine(line);
                    }
                }
            }
        }
        
        Console.WriteLine("File {0} created.", resultFileName);


    }
}