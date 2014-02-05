//2.7. Declare two string variables and assign them with “Hello” and “World”.
//Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval).
//Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

using System;

class HelloWorld
{
    static void Main()
    {
        // Declare variables
        string firstWord = "Hello";
        string secondWord = "World";

        // Declare variable and concatenation
        object sentence = firstWord + " " + secondWord;

        // Declare variable and initialize
        string greeting = (string)sentence;
        
        // Print the results on the console
        Console.WriteLine(greeting);

        //Wait for key press
        Console.ReadKey();
    }
}
