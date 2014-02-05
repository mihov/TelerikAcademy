//1.7.	Create a console application that prints the current date and time.
using System;
class PrintsTheCurrentDateAndTime
{
    static void Main()
    {
        Console.Title = "1.7. Print Current Date And Time";
        Console.Write("Current time is ");
        Console.WriteLine(DateTime.Now.ToShortTimeString());
        Console.Write("Current date is ");
        Console.WriteLine(DateTime.Now.ToShortDateString());
        Console.ReadKey();
    }
}
