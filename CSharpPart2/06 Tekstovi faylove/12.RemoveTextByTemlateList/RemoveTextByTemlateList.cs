// 12. Write a program that removes from a text file all words listed in given another text file.
// Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Text.RegularExpressions;

class RemoveTextByTemlateList
{
    static string testFileName = @"..\..\test.txt";
    static string listFileName = @"..\..\list.txt";
    static string resultFileName = @"..\..\result.txt";
    
    static void Main()
    {
        try
        {
            // Reads words to remove list
            string removeleList = @"\b(" + String.Join("|", File.ReadAllLines(listFileName)) + @")\b";
            
            // Reads all input file
            string fileContent = File.ReadAllText(testFileName);
            
            // Write result to result.txt
            File.WriteAllText(resultFileName, Regex.Replace(fileContent, removeleList, String.Empty, RegexOptions.IgnoreCase));
            
            Console.WriteLine("Words from list deleted!");
        }
        
        // Exceptions
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory Not Found!");
        }        
        
        catch (FileNotFoundException)
        {
            Console.WriteLine("File Not Found!");
        }
        
        catch (IOException)
        {
            Console.WriteLine("Input/Output Error!");
        }
        
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("File Access Error!");
        }
    }
}
