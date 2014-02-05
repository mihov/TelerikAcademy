//1.8.	Create a console application that calculates and prints the square of the number 12345.
using System;
class PrintsTheSquareOfTheNumber12345
{
    static void Main()
    {
        Console.Title = "1.8. Prints The Square Of The Number 12345";
        int number = 12345;
        int square = number * number;
        Console.WriteLine("The Square Of The Number {0} is {1}", number, square);
        Console.ReadKey();
    }
}
