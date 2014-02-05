//2.10. A marketing firm wants to keep record of its employees. 
//Each record would have the following characteristics – 
//first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999). 
//Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.

using System;

class Employees
{
    static void Main()
    {
        // Declare variables
        string firstName = "Tancho";
        string familyName = "Mihov";
        byte age = 35;
        char gender = 'm';
        string idNumber = "BG123456";
        uint ueNumber = 27560001;
      
        // Print the result on the console
        Console.WriteLine(" ___________________________________");
        Console.WriteLine("| Employee infomation box");
        Console.WriteLine("|___________________________________");
        Console.WriteLine("| First name      : {0}", firstName);
        Console.WriteLine("| Family name     : {0}", familyName);
        Console.WriteLine("| Äge             : {0}", age);
        Console.WriteLine("| Gender          : {0}", gender);
        Console.WriteLine("| ID Number       : {0}", idNumber);
        Console.WriteLine("| Employee number : {0}", ueNumber);
        Console.WriteLine("|___________________________________");

        // Wait for key press
        Console.ReadKey();
    }
}
    