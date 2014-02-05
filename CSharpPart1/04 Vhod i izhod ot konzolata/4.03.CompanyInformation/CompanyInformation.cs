// 4.03. A company has name, address, phone number, fax number, web site and manager.
// The manager has first name, last name, age and a phone number.
// Write a program that reads the information about a company and its manager and prints them on the console.

using System;

class CompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Please enter informatin about:");
        Console.WriteLine("\n    Company:");
        Console.Write("        Name         : ");
        string companyName = Console.ReadLine();

        Console.Write("        Address      : ");
        string companyAddress = Console.ReadLine();

        Console.Write("        Phone number : ");
        string companyPhoneNumber = Console.ReadLine();

        Console.Write("        Fax number   : ");
        string companyFaxNumber = Console.ReadLine();

        Console.Write("        Web site     : ");
        string companyWebSite = Console.ReadLine();

        Console.WriteLine("\n    Manager: ");
        Console.Write("        First name   : ");
        string managerFirstName = Console.ReadLine();

        Console.Write("        Last name    : ");
        string managerLastName = Console.ReadLine();

        Console.Write("        Age          : ");
        byte managerAge;
        byte.TryParse(Console.ReadLine(), out managerAge);

        Console.Write("        Phone number : ");
        string managerPhoneNumber = Console.ReadLine();


        Console.WriteLine("\n\n    Informatin about : {0}", companyName);
        Console.WriteLine("             Address : {0}", companyAddress);
        Console.WriteLine("        Phone number : {0}", companyPhoneNumber);
        Console.WriteLine("          Fax number : {0}", companyFaxNumber);
        Console.WriteLine("            Web site : {0}", companyWebSite);

        Console.WriteLine("\n              Manager: ");
        Console.WriteLine("          First name : {0}", managerFirstName);
        Console.WriteLine("           Last name : {0}", managerLastName);
        Console.WriteLine("                 Age : {0}", managerAge);
        Console.WriteLine("        Phone number : {0}", managerPhoneNumber);
    }
}
/** Console output: 
Please enter informatin about:

    Company:
        Name         : Intel Bulgaria Ltd.
        Address      : Bulgaria, Sofia, Bulgaria Blvd. 35
        Phone number : +359 2 1234 5678
        Fax number   : +359 2 9876 5432
        Web site     : www.intel.bg

    Manager:
        First name   : Ivan
        Last name    : Ivanov
        Age          : 35
        Phone number : +359 888 777 666


   Informatin about : Intel Bulgaria Ltd.
            Address : Bulgaria, Sofia, Bulgaria Blvd. 35
       Phone number : +359 2 1234 5678
         Fax number : +359 2 9876 5432
           Web site : www.intel.bg

             Manager:
         First name : Ivan
          Last name : Ivanov
                Age : 35
       Phone number : +359 888 777 666
Press any key to continue . . .
**/