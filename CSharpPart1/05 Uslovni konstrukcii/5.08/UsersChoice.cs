// 5.8. Write a program that, depending on the user's choice inputs int, double or string variable.
// If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end.
// The program must show the value of that variable as a console output. Use switch statement.

using System;           // V.1

class UsersChoice
{
    static void Main()
    {
        Console.Write("Enter someting: ");
        string theValue = Console.ReadLine();
        int varInt;
        double varDouble;
        if (int.TryParse(theValue, out varInt))
        {
            Console.WriteLine("You entered value of type {0}", varInt.GetType());
            Console.WriteLine(varInt + 1);
        }
        else if (double.TryParse(theValue, out varDouble))
        {
            Console.WriteLine("You entered value of type {0}", varDouble.GetType());
            Console.WriteLine(varDouble + 1);
        }
        else
        {
            Console.WriteLine("You entered value of type {0}", theValue.GetType());
            Console.WriteLine(theValue + "*");
        }
    }
}
/** Console Output:
Enter someting: 5
You entered value of type System.Int32
6
Press any key to continue . . .
***********************************************
Enter someting: 5.5
You entered value of type System.Double
6.5
Press any key to continue . . . 
*********************************************** 
Enter someting: qwerty
You entered value of type System.String
qwerty*
Press any key to continue . . .
**/