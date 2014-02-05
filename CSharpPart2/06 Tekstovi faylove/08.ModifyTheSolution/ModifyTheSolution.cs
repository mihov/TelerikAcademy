// 08. Modify the solution of the previous problem to replace only whole words (not substrings).

using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;


class ModifyTheSolution
{
    // Define global variables
    static string testFileName = @"..\..\test.txt";
    static string tempFileName = @"..\..\temp.txt";
    static string oldValue = "start";
    static string newValue = "final";

    static void Main()
    {


        // Define files for reading and writing
        StreamReader testFile = new StreamReader(testFileName);
        StreamWriter tempFile = new StreamWriter(tempFileName);

        using (testFile)
        {
            using (tempFile)
            {

                // This make posible to replace only whole words
                oldValue = @"\b" + oldValue + @"\b";

                string tempLine;

                // Reads file line by line
                while ((tempLine = testFile.ReadLine()) != null)
                {
                    // Do replace
                    tempLine = Regex.Replace(tempLine, oldValue, newValue);

                    // Write new line to temp file
                    tempFile.WriteLine(tempLine);
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
