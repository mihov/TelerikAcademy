// 03. Write a program that prints to the console which day of the week is today.
// Use System.DateTime.

using System;
using System.Text;

class Today
{
    static void Main()
    {

        Console.OutputEncoding = Encoding.UTF8;

        // Define array with days of ween
        string[] dayOfWeek = { 
                           
                "Sunday",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday"
                           };
        // Get current day in "today"
        int today = (int)DateTime.Now.DayOfWeek;

        // Print result
        Console.WriteLine("Today, {0} is {1}.", DateTime.Now.Date.ToShortDateString(), dayOfWeek[today]);
    }
}

/** Console output:
Today, 13.1.2014 г. is Monday.
Press any key to continue . . .
**/