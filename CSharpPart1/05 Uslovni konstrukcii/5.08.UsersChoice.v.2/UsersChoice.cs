// 5.8. Write a program that, depending on the user's choice inputs int, double or string variable.
// If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end.
// The program must show the value of that variable as a console output. Use switch statement.

using System;           // V.2

class UsersChoice
{
    static void Main()
    {
        // Print some information
        Console.WriteLine("Enter the type of variable.");
        Console.WriteLine("[1] - int\n[2] - double\n[3] - string");

        ConsoleKeyInfo typeVar = Console.ReadKey(); // Read the client's answer
        switch (typeVar.KeyChar.ToString())
        {
            case "1":
                Console.Write("\nEnter some INT: ");// Read the client's value and increase it
                Console.WriteLine("             >> " + (int.Parse(Console.ReadLine()) + 1) + " <<");
                break;
            case "2":
                Console.Write("\nEnter some DOUBLE: ");// Read the client's value and increase it
                Console.WriteLine("               >>  " + (double.Parse(Console.ReadLine()) + 1) + " <<");
                break;
            case "3":
                Console.Write("\nEnter some STRING: ");// Read the client's value and appends "*" at its end
                Console.WriteLine("                >> " + Console.ReadLine() + "* <<");
                break;
            default:
                Console.WriteLine("\nUnable to convert!");
                break;
        }
    }
}
/** Console output:
Enter the type of variable.
[1] - int
[2] - double
[3] - string
1
Enter some INT: 5
             >> 6
Press any key to continue . . .
**/