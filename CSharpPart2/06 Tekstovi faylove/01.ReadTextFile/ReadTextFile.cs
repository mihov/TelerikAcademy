// 01. Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;

class ReadTextFile
{
    static void Main()
    {
        string fileName = @"..\..\test.txt";
        Console.WriteLine("Odd lines of {0} are:", fileName);

        StreamReader fileStream = new StreamReader(fileName);

        using (fileStream)
        {
            int lineNumber = 1;

            string line = fileStream.ReadLine();
            while (line != null)
            {
                if (lineNumber % 2 != 0)
                {
                    Console.WriteLine(line);
                    line = fileStream.ReadLine();
                }
            }
        }

    }
}