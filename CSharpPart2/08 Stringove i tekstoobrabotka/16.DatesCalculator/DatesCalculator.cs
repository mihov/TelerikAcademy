// 16. Write a program that reads two dates in the format: 
// day.month.year and calculates the number of days between them. 

using System;

class DatesCalculator
{
    static void Main()
    {
        Console.WriteLine("Days counter.");
        
        // Reads first date
        Console.Write("Enter first date  (dd.mm.yyyy): ");
        string[] tempDate = Console.ReadLine().Split(new char[] {'.', '/', ',', '\\', ' '}, StringSplitOptions.RemoveEmptyEntries);

        // Parse first date
        DateTime firstrDate = new DateTime(int.Parse(tempDate[2]), int.Parse(tempDate[1]), int.Parse(tempDate[0]));

        // Reads second date
        Console.Write("Enter second date (dd.mm.yyyy): ");
        tempDate = Console.ReadLine().Split(new char[] {'.', '/', ',', '\\', ' '}, StringSplitOptions.RemoveEmptyEntries);

        // Parse second date
        DateTime secondDate = new DateTime(int.Parse(tempDate[2]), int.Parse(tempDate[1]), int.Parse(tempDate[0]));

        // Calculates the time span
        TimeSpan newDate = firstrDate - secondDate;

        // Prints the result
        Console.WriteLine("\nDays between {0} and {1} are {2}.", firstrDate.ToShortDateString(), secondDate.ToShortDateString(), Math.Abs(newDate.Days));
    }
}

/** Console output:
Days counter.
Enter first date  (dd.mm.yyyy): 24.05.2014
Enter second date (dd.mm.yyyy): 01.05.2014

Days between 24.5.2014 г. and 1.5.2014 г. are 23.
Press any key to continue . . .
**/