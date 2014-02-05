//1.6.	Create console application that prints your first and last name.
using System;
class PrintsFirstAndLastName
{
    static void Main()
    {
        Console.Title = "1.6. Prints your first and last name";
        Console.Write("First name: ");
        Console.WriteLine("Tancho");
        Console.WriteLine("{0}{1}","Last  name: ","Mihov");
        Console.ReadKey();
    }
}
