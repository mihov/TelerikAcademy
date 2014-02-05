// 19. Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
// Display them in the standard date format for Canada.

using System;
using System.Globalization;
using System.Text.RegularExpressions;

class DateExtractor
{
    static void Main()
    {
        // Reads input text
        Console.WriteLine("Enter/paste a text which content dates.");
        string inputText = Console.ReadLine();

        // Define the pattern
        string pattern = @"\d{1,2}\.\d{1,2}\.\d{4}";

        // Define CultureInfo
        var provider = new CultureInfo("en-CA", false);

        // Collect maches
        MatchCollection dateCollection = Regex.Matches(inputText, pattern);

        // Print the result
        Console.WriteLine("\nCollected dates:");
        foreach (var dates in dateCollection)
        {
            DateTime currentDateelement;
            DateTime.TryParse(dates.ToString(), out currentDateelement);
            Console.WriteLine(currentDateelement.ToString("dd/MM/yyyy", provider));
        }
    }
}

/** Console output:
Enter/paste a text which content dates.
На 20.01.2014 г. ще се проведе публична защита на отборната работа през целия де
н в зала Light. Когато наближи, ще получите повече информация, но датата е фикси
рана. На 22.01.2014 и 24.01.2014 януари ще се проведе изпита по C# Част 2. Това
са фиксираните

Collected dates:
20/01/2014
22/01/2014
24/01/2014
Press any key to continue . . .
**/