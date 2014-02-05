// 15. Write a program that replaces in a HTML document given as string all the tags
// <a href="…">…</a> with corresponding tags [URL=…]…/URL]. 

using System;

class ReplacesHTML
{
    static void Main()
    {
        // Reads HTML document
        Console.WriteLine("Enter/Paste a HTML document.");
        string htmlDocument = Console.ReadLine();

        // Define old tags
        string oldOpenTag = "<a href=\"";
        string oldCloseTag = "</a>";

        // Define new tags
        string newOpenTag = "[URL=";
        string newCloseTag = "[/URL]";

        // Replace all tags
        htmlDocument = htmlDocument.Replace(oldOpenTag, newOpenTag)
                                   .Replace(oldCloseTag, newCloseTag)
                                   .Replace("\">", "]");

        // Print the result
        Console.WriteLine("\nHTML Document with corresponding tags.");
        Console.WriteLine(htmlDocument);
    }
}

/** Console output:
Enter/Paste a HTML document.
<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a t
raining course. Also visit <a href="www.devbg.org">our forum</a> to discuss the
courses.</p>

HTML Document with corresponding tags.
<p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a trai
ning course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the course
s.</p>
Press any key to continue . . .
**/