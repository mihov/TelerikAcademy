// 02. Write a program that reads a string, reverses it and prints the result at the console.
//     Example: "sample" ==> "elpmas".

using System;

class ReadsReversesPrints
{
    static void Main()
    {
        Console.Write("Enter string: ");

        // Reads message
        string message = Console.ReadLine();

        // Reverse message
        message = Reverse(message);

        // Print reversed message to console
        Console.WriteLine("Reversed message is: {0}.", message);
    }

    /// <summary>
    /// Return reversed string.
    /// </summary>
    /// <param name="text">Given string.</param>
    /// <returns>Reversed string.</returns>
    static string Reverse(string text)
    {
        // Copy message to cha array
        char[] charArray = text.ToCharArray();
        
        string reverse = String.Empty;

        // Loop for all elements end to begin
        for (int i = charArray.Length - 1; i > -1; i--)
        {
            // Put chars to array
            reverse += charArray[i];
        }
        
        // Return result.
        return reverse;
    }
}

/** Console output:
Enter string: HEllo
Reversed message is: ollEH.
Press any key to continue . . .
**/