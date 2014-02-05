// 07. Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file.
// Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;
using System.Text;

class ReplacesInFile
{
    // Define global variables
    static string testFileName = @"..\..\test.txt";
    static string tempFileName = @"..\..\temp.txt";
    static string oldValue = "start";
    static string newValue = "final";

    static void Main()
    {
        // Dfine "line"
        StringBuilder line = new StringBuilder();

        // Define files for reading and writing
        StreamReader testFile = new StreamReader(testFileName);
        StreamWriter tempFile = new StreamWriter(tempFileName);

        using (testFile)
        {
            using (tempFile)
            {
                string tempLine;
                
                // Reads file line by line
                while ((tempLine = testFile.ReadLine()) != null)
                {
                    line.Append(tempLine);
                    
                    // Do replace
                    line.Replace(oldValue, newValue);
                    
                    // Write new line to temp file
                    tempFile.WriteLine(line.ToString());
                    line.Clear();
                }
            }
        }

        // Copying lines from temp file to the test file and delete temp file.
        MoveFromTo(tempFileName, testFileName);

        Console.WriteLine("Replacement complete successfully!");
    }

    // Copying lines from first file to the second file and delete it.
    static void MoveFromTo(string copyFromFileName, string copyToFileName)
    {
        StreamReader copyFrom = new StreamReader(copyFromFileName);
        StreamWriter copyTo = new StreamWriter(copyToFileName);
        using (copyFrom)
        {
            using (copyTo)
            {
                string tempLine;
                while ((tempLine = copyFrom.ReadLine()) != null)
                {
                    copyTo.WriteLine(tempLine);  
                }
            }
        }
        
        // Delete temp file
        File.Delete(tempFileName);
    }
}