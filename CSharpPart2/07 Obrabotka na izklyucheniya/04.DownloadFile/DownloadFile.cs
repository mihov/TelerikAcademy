// 04. Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg)
// and stores it the current directory. Find in Google how to download files in C#.
// Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        Console.WriteLine("Enter the URL of the file to download it: ");

        Uri uriURL = new Uri(Console.ReadLine());

        string fileName = System.IO.Path.GetFileName(uriURL.LocalPath);

        WebClient webClient = new WebClient();

        try
        {
            // Where to save the file
            webClient.DownloadFile(uriURL, "../../" + fileName);
            Console.WriteLine("The file was successfully downloaded!");
        }

        // Exceptions
        catch (WebException)
        {
            Console.WriteLine("Invalid adress or empty file!");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Called method is not supported!");
        }
        finally
        {
            webClient.Dispose();
        }
    }
}

/** Console output:
Enter the URL of the file to download it:
http://www.telerik.com/assets/img/telerik-navigation/telerik-logo.png
The file was successfully downloaded!
!
Press any key to continue . . .
**/