//1.12.	Write a program to read your age from the console and print how old you will be after 10 years.
using System;
class PrintAgeAfter10Years
{
    static void Main()
    {
        Console.Title = "1.12. Prints how old you will be after 10 years";
        Console.WriteLine("\nHow old are you?");
        Console.Write("Enter your years here:");
        
        string yearsAsString = Console.ReadLine();                                                                  //Read from console.
        int years;
        bool parseSuccess = int.TryParse(yearsAsString, out years);                                                 //Trying to Parse (String to Int)
        
        Console.WriteLine(parseSuccess ? "\nYou are {0} years old now.\nAfter 10 years you will be {1} years old."  //If Success parse.
                                       : "\nNext time enter correct value of your years!\nBye!",                    //If NO success parse.
                                       years, years + 10);    
        Console.ReadKey();    }
}