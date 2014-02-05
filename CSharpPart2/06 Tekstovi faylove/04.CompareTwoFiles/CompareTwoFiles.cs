// 04. Write a program that compares two text files line by line
// and prints the number of lines that are the same
// and the number of lines that are different.
// Assume the files have equal number of lines.

using System;
using System.IO;

class CompareTwoFiles
{
    static void Main()
    {
        // Sets the path to input files.
        string firstFileName = @"..\..\file1.txt";
        string secondFileName = @"..\..\file2.txt";

        // Declares instances for input files.
        StreamReader firstFile = new StreamReader(firstFileName);
        StreamReader secondFile = new StreamReader(secondFileName);

        // Declare counters
        int samelLineCounter = 0;
        int differentLineCounter = 0;

        using (firstFile)
        {
            using (secondFile)
            {
                // Declare variables for lines
                string firstFileLine;
                string secondFileLine;


                // Reads lines by lines from both input files till end of them.
                while (((firstFileLine = firstFile.ReadLine()) != null)
                    && ((secondFileLine = secondFile.ReadLine()) != null))
                {
                    // Compare lines and increase counters
                    if (string.Compare(firstFileLine, secondFileLine, false) == 0)
                    {
                        samelLineCounter++;
                    }
                    else
                    {
                        differentLineCounter++;
                    }
                }

                // Prints the result
                Console.WriteLine("File 1 and file 2 had {0} same lines and {1} different lines.", samelLineCounter, differentLineCounter);
            }
        }
    }
}

/** Concole output:
File 1 and file 2 had 5 same lines and 6 different lines.
Press any key to continue . . .
**/