// 07. Write a program that encodes and decodes a string using given encryption key (cipher).
// The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or)
// operation over the first letter of the string with the first of the key, the second – with the second, etc.
// When the last key character is reached, the next is the first.

using System;
using System.Text;

class EncodeDecode
{
    static void Main(string[] args)
    {
        // Reads the text
        Console.Write("Enter a text: ");
        string planeText = Console.ReadLine();

        // Reads the cipher
        Console.Write("Enter a cipher: ");
        string cipher = Console.ReadLine();

        Console.WriteLine("Codet/Decodet text is: ");
        // Do encode/decode
        string result = StringCoder(planeText, cipher);

        // Print the result
        Console.WriteLine(result);
    }

    static string StringCoder(string theText, string theKey)
    {
        StringBuilder result = new StringBuilder(theKey.Length);

        // Loop for all "text" chars
        for (int position = 0; position < theText.Length; position++)
        {
            // Append all encodet/decodet chars
            result.Append(CharCoderDecoder(theText[position], theKey[position % (theKey.Length)]));
        }

        return result.ToString();
    }

    // Do CHAR XOR CHAR
    static char CharCoderDecoder(char inputChar, char cipher)
    {
        char result = (char)((int)inputChar ^ (int)cipher);
        return result;
    }
}

/** Console output:
Enter a text: Telerik Academy
Enter a cipher: sofia
Codet/Decodet text is:
'

♀‼→♦F(☻↕♂♥♦↑
Press any key to continue . . .
**/