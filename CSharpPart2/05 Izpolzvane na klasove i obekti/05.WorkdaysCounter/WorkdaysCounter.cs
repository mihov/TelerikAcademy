// Write a method that calculates the number of workdays between today and given date,
// passed as parameter. Consider that workdays are all days from Monday to Friday
// except a fixed list of public holidays specified preliminary as array.

using System;
using System.Collections.Generic;

class WorkdaysCounter
{

    // List for Public Holidays
    static List<DateTime> publicHolidaysList = new List<DateTime>();

    static void Main()
    {
        // Add list of public holidays specified preliminary
        InitialiseHolidays();

        Console.WriteLine("Enter a date, to count workdays between today and this date: ");

        // Reads "given date" elements
        Console.Write("Year: ");
        int year = int.Parse(Console.ReadLine());

        Console.Write("Month: ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Day: ");
        int day = int.Parse(Console.ReadLine());

        // Declare and set "given date"
        DateTime givenDate = new DateTime(year, month, day);

        // Calculates and prints workdays
        Console.WriteLine("Workdays between today ({0}) and {1} are {2}.", DateTime.Today.ToShortDateString(), givenDate.ToShortDateString(), WorkdaysCNT(givenDate));
    }

    // Calculates workdays
    static int WorkdaysCNT(DateTime theDate)
    {
        int result = 0;

        // Compare today and given date
        if (DateTime.Today <= theDate.Date)
        {
            for (DateTime counter = DateTime.Today; counter < theDate.Date; counter = counter.AddDays(1))
            {
                if (IsWorkday(counter))
                {
                    // Increase only for work days
                    result++;
                }
            }
        }
        else
        {
            for (DateTime counter = theDate.Date; counter < DateTime.Today; counter = counter.AddDays(1))
            {
                if (IsWorkday(counter))
                {
                    // Decrease only for work days
                    result--;
                }
            }
        }
        return result;
    }

    static void InitialiseHolidays()
    {
        // Add Public Holydays every year
        publicHolidaysList.Add(new DateTime(2000, 1, 1));
        publicHolidaysList.Add(new DateTime(2000, 12, 31));
        publicHolidaysList.Add(new DateTime(2000, 5, 24));
        publicHolidaysList.Add(new DateTime(2000, 5, 1));
        publicHolidaysList.Add(new DateTime(2000, 3, 3));
    }


    // Check is current day Public Holyday, every year
    static bool IsPublicHolyday(DateTime theDay)
    {
        foreach (DateTime item in publicHolidaysList)
        {
            if (item.Day == theDay.Day && item.Month == theDay.Month)
            {
                return true;
            }
        }
        return false;
    }

    // Check is current day workday and not Public Holyday
    static bool IsWorkday(DateTime theDay)
    {
        if ((int)theDay.DayOfWeek == 0 || (int)theDay.DayOfWeek == 6 || IsPublicHolyday(theDay))
        {
            return false;
        }
        return true;
    }
}

/** Console output:
Enter a date, to count workdays between today and this date:
Year: 2013
Month: 12
Day: 30
Workdays between today (14.1.2014 г.) and 30.12.2013 г. are -9.
Press any key to continue . . .
**/