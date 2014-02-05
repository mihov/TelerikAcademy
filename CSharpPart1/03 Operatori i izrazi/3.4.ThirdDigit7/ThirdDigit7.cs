// 3.4. Write an expression that checks for given integer
// if its third digit (right-to-left) is 7. E. g. 1732 -> true.

using System;

class ThirdDigit7
{
    static void Main()
    {
        // Integer to check
        Console.Write("Enter integer number: ");
        int givenInteger = int.Parse(Console.ReadLine());

        // Convert to string
        string givenString = Convert.ToString(givenInteger, 10);

        // Check if lenght is less then three
        if (givenString.Length >= 3)
        {
            // Extract third chart
            char thirdChar = givenString[(givenString.Length - 3)];

            // Compare the thid chart and 7
            bool areEqual = Char.Equals(thirdChar, '7');

            if (areEqual)
            {
                Console.WriteLine("The third digit of {0} is 7.", givenInteger); // 7 is third digit
            }
            else
            {
                Console.WriteLine("The third digit of {0} is not 7.", givenInteger); // 7 is not third digit
            }
        }
        else
        {
            Console.WriteLine("{0} has not third digit.", givenInteger); // The given integer length is less then 3 digits.
        }
    }
}
/** Console output:
Enter integer number: 7555
The third digit of 7555 is not 7.
Press any key to continue . . .
 * 
Enter integer number: 63725
The third digit of 63725 is 7.
Press any key to continue . . . 
 **/
