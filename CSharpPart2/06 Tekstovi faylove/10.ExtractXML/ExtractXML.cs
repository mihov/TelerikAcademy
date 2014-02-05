// 10. Write a program that extracts from given XML file all the text without the tags.

using System;
using System.Collections.Generic;
using System.IO;

class ExtractXML
{
    static string fileName = @"..\..\test.xml";
    static void Main()
    {
        string line = null;
        List<string> xmlValues = new List<string>();
        
        // Opens file for readinf
        using (StreamReader reader = new StreamReader(fileName))
        {
            // Reads file line by line
            while ((line = reader.ReadLine()) != null)
            {
                // Reads each line char by char
                for (int position = 0; position < line.Length; position++)
                {
                    if (position < line.Length - 1 && line[position] == '>' && line[position + 1] != '<')
                    {
                        int startingIndex = position + 1;
                        int wordLength = 0;
                        while (line[position] != '<')
                        {
                            wordLength++;
                            position++;
                        }
                        // Add  text only to the XML values list
                        xmlValues.Add(line.Substring(startingIndex, wordLength - 1));
                    }
                }
            }
        }

        // Prints content of XML values
        Console.WriteLine("Content of XML file:");
        for (int counter = 0; counter < xmlValues.Count; counter++)
        {
            Console.WriteLine("[{0}] -> {1}", counter + 1, xmlValues[counter]);
        }
    }
}
