// 17. Write a program that reads a date and time given in the format: day.month.year hour:minute:second
// and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
using System;

class AddTimeToDate
{
    static void Main()
    {
        // Reads date and time as string
        Console.Write("Enter Date (day.month.year hour:minute:second): ");
        string inputDate = Console.ReadLine();

        DateTime dateTime;

        // Try to parse string to date time
        if (DateTime.TryParse(inputDate, out dateTime))
        {
            // Calculates and print the result
            Console.Write("\nAfter 6 hours and 30 minutes will be ");
            Console.WriteLine(dateTime.AddMinutes(6 * 60 + 30));
        }
        else
        {
            // Prints error message
            Console.WriteLine("\nIncorrect date or time entered!");
        }
    }
}

/** Console output:
Enter Date (day.month.year hour:minute:second): 10.10.2014 10:30:00

After 6 hours and 30 minutes will be 10.10.2014 г. 17:00:00 ч.
Press any key to continue . . .
**/