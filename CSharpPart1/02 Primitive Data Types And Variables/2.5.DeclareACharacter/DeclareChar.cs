//2.5. Declare a character variable and assign it with the symbol that has Unicode code 72. 
//Hint: first use the Windows Calculator to find the hexadecimal representation of 72.

using System;

class DeclareChar
{
    static void Main()
    {
        // Declare variable
        char charVar = '\u0048';
        
        // Print the results on the console
        Console.WriteLine("The hex value of {0:X} as char is {1}",(int)charVar,charVar);

        //Wait for key press
        Console.ReadKey();

    }
}