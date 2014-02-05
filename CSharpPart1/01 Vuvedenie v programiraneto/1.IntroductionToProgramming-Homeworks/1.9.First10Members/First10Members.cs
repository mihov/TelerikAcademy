//1.9.	Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
using System;
class First10Members
{
    static void Main()
    {
        Console.Title = "1.9. Prints the first 10 members of the sequence";
        Byte howMembers = 10, startWith = 2;                        //Set parameters
        for (int i = startWith; i < howMembers + startWith; i++)
        {
            if ((i % 2)==0)                                         //Odd or even 
            {
                Console.Write("{0}", i);                            //Print odd member
            }
            else
            {
                Console.Write("-{0}", i);                           //Print '-' and even member
            }
            
            if (i < (howMembers+1))
                {
                    Console.Write(", ");                            //Print ',' after every no last member of the sequence     
                }
            else
            {
                Console.WriteLine();                                //This is new line, after last member printed.
            }
        }
        Console.ReadKey();
    }
}
