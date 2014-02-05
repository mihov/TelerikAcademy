// 03. Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini),
// reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). 
// Be sure to catch all possible exceptions and print user-friendly error messages.


using System;
using System.IO;
using System.Security;


class ReadAndPrint
{
    static void Main()
    {
        Console.Write("Enter the full path and file name: ");
        string fullFilePath = Console.ReadLine();
        PrintFileToConsole(fullFilePath);
    }

    static void PrintFileToConsole(string fullFilePath)
    {
        try
        {
            // Reads file content
            string fileContent = File.ReadAllText(fullFilePath);

            Console.WriteLine("Content of file is: ");
            
            // Print file content
            Console.WriteLine(fileContent);
        }

        // Exceptions
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory not found!");
        }

        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found!");
        }

        catch (ArgumentNullException)
        {
            Console.WriteLine("Please enter valid file path!");
        }

        catch (ArgumentException)
        {
            Console.WriteLine("Please enter valid file path!");
        }

        catch (PathTooLongException)
        {
            Console.WriteLine("The file Path must not be longer than 248 characters!");
        }

        catch (UnauthorizedAccessException accessError)
        {
            Console.WriteLine(accessError.Message);
        }

        catch (SecurityException)
        {
            Console.WriteLine("You don't have permission to access this file!");
        }

        catch (NotSupportedException)
        {
            Console.WriteLine("Invalid path!");
        }

        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
    }
}