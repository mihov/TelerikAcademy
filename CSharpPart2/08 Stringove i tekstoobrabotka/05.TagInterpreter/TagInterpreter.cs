// 05. You are given a text.
// Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase.
// The tags cannot be nested. 

// We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.


using System;
using System.Text;

class TagInterpreter
{
    static void Main()
    {
        // Reads the input text
        Console.WriteLine("Enter text to interpret:");
        StringBuilder upCaseTest = new StringBuilder(Console.ReadLine());

        // Dfine open and close tags
        string openTag = "<upcase>";
        string closeTag = "</upcase>";

        // Define start and end position for upper case text
        int startUpTextIndex = 0;
        int endUpTextIndex = 0;

        // Loop for all element of the text
        for (int position = 0; position < upCaseTest.Length - closeTag.Length; position++)
        {
            // Calculate the position of next open tag
            startUpTextIndex = upCaseTest.ToString().IndexOf(openTag, startUpTextIndex);

            // If open tag exist
            if (startUpTextIndex >= 0)
            {
                // Delete open tag
                upCaseTest.Remove(startUpTextIndex, openTag.Length);

                //  Calculate the position of next close tag
                endUpTextIndex = upCaseTest.ToString().IndexOf(closeTag, startUpTextIndex);

                // If close tag exist
                if (endUpTextIndex >= 0)
                {
                    // Delete close tag
                    upCaseTest.Remove(endUpTextIndex, closeTag.Length);

                    // Change all letters from open and close tags position
                    for (int subPosition = startUpTextIndex; subPosition <= endUpTextIndex; subPosition++)
                    {
                        upCaseTest[subPosition] = char.ToUpper(upCaseTest[subPosition]);
                    }
                }
                else
                {
                    break;
                }
            }
            else
            {
                break;
            }
        }
        
        // Prints result to console
        Console.WriteLine();
        Console.WriteLine("Interpreted text:");
        Console.WriteLine(upCaseTest.ToString());
    }
}

/** Console output:
Enter text to interpret:
We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anyt
hing</upcase> else.

Interpreted text:
We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
Press any key to continue . . .
**/