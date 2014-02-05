//2.9. Write a program that prints an isosceles triangle of 9 copyright symbols ©. 
//Use Windows Character Map to find the Unicode code of the © symbol. 
//Note: the © symbol may be displayed incorrectly.

using System;
using System.Text;

class Triangle
{
    static void Main()
    {
        
        Console.OutputEncoding = Encoding.UTF8;
        
        // First easy way
        Console.WriteLine(" First easy way");
        Console.WriteLine(@"
   ©
  ©©©
 ©©©©©");

        

        // Second easy way  
        char copyRight = '\u00A9';
        char empty = ' ';

        Console.WriteLine();
        Console.WriteLine("\n\n\n Second easy way\n");
        Console.WriteLine("{0}{0}{0}{1}{0}{0}", empty,copyRight);
        Console.WriteLine("{0}{0}{1}{1}{1}{0}", empty,copyRight);
        Console.WriteLine("{0}{1}{1}{1}{1}{1}", empty,copyRight);

        //Wait for key press
        Console.ReadKey();
    }
}