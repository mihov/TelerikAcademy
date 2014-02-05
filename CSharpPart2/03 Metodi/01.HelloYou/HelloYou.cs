// 01. Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). Write a program to test this method.

using System;

class HelloYou
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        
        // Call the method Hello.
        Hello(Console.ReadLine());
    }

    /// <summary>
    /// Prints “Hello, name!”
    /// </summary>
    /// <param name="yourName">String = your name.</param>
    static void Hello(string yourName)
    {
        Console.WriteLine("Hello, " + yourName + "!");
    }
}

/** Console output.
Enter your name: Peter
Hello, Peter!
Press any key to continue . . .
 **/
