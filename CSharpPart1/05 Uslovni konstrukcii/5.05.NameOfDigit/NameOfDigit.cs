// 5.5. Write program that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.

using System;

class NameOfDigit
{
    static void Main()
    {
        // Read value from console
        Console.Write("Enter a digit [0 - 9]: ");
        char digit = (char)Console.ReadLine()[0];
        
        // Compare "digit" and print result 
        switch (digit)
        {
            case '0':
                Console.WriteLine("Zero");
                break;
            case '1':
                Console.WriteLine("One");
                break;
            case '2':
                Console.WriteLine("Two");
                break;
            case '3':
                Console.WriteLine("three");
                break;
            case '4':
                Console.WriteLine("four");
                break;
            case '5':
                Console.WriteLine("five");
                break;
            case '6':
                Console.WriteLine("six");
                break;
            case '7':
                Console.WriteLine("seven");
                break;
            case '8':
                Console.WriteLine("eight");
                break;
            case '9':
                Console.WriteLine("nine");
                break;
            default:
                Console.WriteLine("Unable to convert!"); // If unable to convert
                break;
        }
    }
}