// 2.12. Find online more information about ASCII (American Standard Code for Information Interchange) 
//and write a program that prints the entire ASCII table of characters on the console.

using System;
using System.Text;

class ASCIItable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;

        ushort lengthOfASCII = 128; // 128 for ASCII; 256 for extended ASCII; the cyrillic is between 1040 - 1103
        
        for (ushort i = 0; i <= lengthOfASCII; i++)
        {
            // Print the char on the console
            Console.Write("{0} ",(char)i);
            
            // New line after each 32 chars
            if ( (i % 32) == 0)
            {
                Console.WriteLine();
            }
        }
        
        // Wait for key press
        Console.ReadKey();
    }
}