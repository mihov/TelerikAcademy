// 2.14. A bank account has a holder name (first name, middle name and last name), 
//available amount of money (balance), bank name, IBAN, BIC code 
//and 3 credit card numbers associated with the account. 
//
//Declare the variables needed to keep the information for a single bank account 
//using the appropriate data types and descriptive names.

using System;

class BankAccount
{
    static void Main()
    {
        // Declare some variables
        string firstName = "Tancho";
        string midName = "Petkov";
        string lastName = "Mihov";

        decimal balance = 1000000.00M;
        string bankName = "Wachovia";
        string IBAN = "US82 PNBP 1234 5698 7654 32";
        string BIC = "PNBPUS33";

        string card1Number = "1111222233334444";
        string card2Number = "2222333344445555";
        string card3Number = "3333444455556666";

        // Print the bank account
        Console.WriteLine("#################################################");
        Console.WriteLine("#                  Bank account                 #");
        Console.WriteLine("#################################################\n");
        Console.WriteLine("  Holder name     : {0} {1} {2}", firstName, midName, lastName);
        Console.WriteLine("  Available amount: {0:C}", balance);
        Console.WriteLine("  Bank name       : {0}", bankName);
        Console.WriteLine("  IBAN            : {0}", IBAN);
        Console.WriteLine("  BIC code        : {0}", BIC);
        Console.WriteLine();
        Console.WriteLine("  Credit card 1 number : {0}", card1Number);
        Console.WriteLine("  Credit card 2 number : {0}", card2Number);
        Console.WriteLine("  Credit card 3 number : {0}", card3Number);
        Console.WriteLine("");
        Console.WriteLine("#################################################");

        // Wait for key press
        Console.ReadKey();
    }
}
