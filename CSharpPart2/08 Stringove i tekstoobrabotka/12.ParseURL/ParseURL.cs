/** 12. Write a program that parses an URL address given in the format:
        and extracts from it the [protocol], [server] and [resource] elements.
        
        For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
		[protocol] = "http"
		[server] = "www.devbg.org"
		[resource] = "/forum/index.php"
**/
using System;
using System.Text.RegularExpressions;

class ParseURL
{
    static void Main()
    {
        // Reads the URL
        Console.Write("Enter an URL adress:");
        string url = Console.ReadLine();

        // Define Regular Expression Pattern
        string regexPattern = @"(?<protocol>^(ht|f)tp(s?))\:\/\/(?<server>(?:www\.)?[a-zA-Z0-9\.]+\.[a-z]{2,4})(?<resource>.*)";

        // Find maches
        if (Regex.IsMatch(url, regexPattern))
        {
            // Collect maches
            MatchCollection collection = Regex.Matches(url, regexPattern);
            
            // Print the result
            foreach (Match value in collection)
            {
                Console.WriteLine("[Protocol] = \"{0}\"", value.Groups["protocol"].Value);
                Console.WriteLine("[Server]   = \"{0}\"", value.Groups["server"].Value);
                Console.WriteLine("[Resource] = \"{0}\"", value.Groups["resource"].Value);
            }
        }
        else
        {
            Console.WriteLine("Invalid URL!");
        }
    }
}

/** Console ooutput:
Enter an URL adress:http://www.devbg.org/forum/index.php
[Protocol] = "http"
[Server]   = "www.devbg.org"
[Resource] = "/forum/index.php"
Press any key to continue . . .
**/