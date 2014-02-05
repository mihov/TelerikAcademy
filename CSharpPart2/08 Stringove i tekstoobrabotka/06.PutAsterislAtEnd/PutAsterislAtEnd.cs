// 06. Write a program that reads from the console a string of maximum 20 characters.
// If the length of the string is less than 20, the rest of the characters should be filled with '*'.
// Print the result string into the console.

using System;

class PutAsterislAtEnd
{
    static void Main(string[] args)
    {
        // Reads the text 
        Console.Write("Enter a text: ");
        string string20Chars = Console.ReadLine();
        
        // Print the text
        Console.WriteLine("Output text: {0}.", string20Chars.PadRight(20, '*'));
        //Console.WriteLine("Output text: {0}.", string20Chars.PadLeft(20, '*'));
    }
}

/** Console output:
Enter a text: telerik.com
Output text: telerik.com*********.
Press any key to continue . . .
**/