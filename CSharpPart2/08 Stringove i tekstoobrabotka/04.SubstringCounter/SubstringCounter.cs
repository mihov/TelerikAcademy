// 04. Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).

using System;

class SubstringCounter
{
    static void Main()
        {
            Console.Write("Enter a text: ");
            string text = Console.ReadLine();

            Console.Write("Enter substring to count it: ");
            string subString = Console.ReadLine();

            text = text.ToLower();
            subString = subString.ToLower();

            Console.WriteLine("The result is:{0}.", SubStrCounter(text, subString));
        }

    static int SubStrCounter(string text, string subString)
    {
        int counter = 0;
        for (int position = 0; position < text.Length - subString.Length ; position++)
        {
            if (text.Substring(position, subString.Length) == subString)
            {
                counter++;
            }
        }
        return counter;
    }
}

/** Console output:
Enter a text: We are living in an yellow submarine. We don't have anything else.
 Inside the submarine is very tight. So we are drinking all the day. We will mov
e out of it in 5 days.
Enter substring to count it: in
The result is:9.
Press any key to continue . . .
**/