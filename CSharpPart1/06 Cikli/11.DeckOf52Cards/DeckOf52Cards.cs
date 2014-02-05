// 11. Write a program that prints all possible cards from a standard deck of 52 cards (without jokers).
// The cards should be printed with their English names. Use nested for loops and switch-case. 

using System;

class DeckOf52Cards
{
    static void Main()
    {
        for (int name = 1; name <= 13; name++)                              // Loop from ACE to KING
        {
            for (int suit = 1; suit <= 4; suit++)                           // Loop from CLUBS to SPADES
            {
                Console.Write("|");                                         // Print left border
                switch (name)                                               // Choose the name 
                {
                    // Print names
                    case 1: Console.Write("ACE".PadLeft(5, ' ')); break;
                    case 2: Console.Write("TWO".PadLeft(5, ' ')); break;
                    case 3: Console.Write("THREE".PadLeft(5, ' ')); break;
                    case 4: Console.Write("FOUR".PadLeft(5, ' ')); break;
                    case 5: Console.Write("FIVE".PadLeft(5, ' ')); break;
                    case 6: Console.Write("SIX".PadLeft(5, ' ')); break;
                    case 7: Console.Write("SEVEN".PadLeft(5, ' ')); break;
                    case 8: Console.Write("EIGHT".PadLeft(5, ' ')); break;
                    case 9: Console.Write("NINE".PadLeft(5, ' ')); break;
                    case 10: Console.Write("TEN".PadLeft(5, ' ')); break;
                    case 11: Console.Write("JACK".PadLeft(5, ' ')); break;
                    case 12: Console.Write("QUEEN".PadLeft(5, ' ')); break;
                    case 13: Console.Write("KING".PadLeft(5, ' ')); break;
                    default: break;
                }

                switch (suit)                                               // Choose the suit
                {
                    // Print the suit
                    case 1: Console.Write(" OF CLUBS".PadRight(13, ' ')); break;
                    case 2: Console.Write(" OF DIAMONDS".PadRight(13, ' ')); break;
                    case 3: Console.Write(" OF HEARTS".PadRight(13, ' ')); break;
                    case 4: Console.WriteLine(" OF SPADES |".PadRight(13, ' ')); break; // Print the suit, right border and new line
                    default: break;
                }
            }

        }
    }
}
/** Console output:
|  ACE OF CLUBS    |  ACE OF DIAMONDS |  ACE OF HEARTS   |  ACE OF SPADES |
|  TWO OF CLUBS    |  TWO OF DIAMONDS |  TWO OF HEARTS   |  TWO OF SPADES |
|THREE OF CLUBS    |THREE OF DIAMONDS |THREE OF HEARTS   |THREE OF SPADES |
| FOUR OF CLUBS    | FOUR OF DIAMONDS | FOUR OF HEARTS   | FOUR OF SPADES |
| FIVE OF CLUBS    | FIVE OF DIAMONDS | FIVE OF HEARTS   | FIVE OF SPADES |
|  SIX OF CLUBS    |  SIX OF DIAMONDS |  SIX OF HEARTS   |  SIX OF SPADES |
|SEVEN OF CLUBS    |SEVEN OF DIAMONDS |SEVEN OF HEARTS   |SEVEN OF SPADES |
|EIGHT OF CLUBS    |EIGHT OF DIAMONDS |EIGHT OF HEARTS   |EIGHT OF SPADES |
| NINE OF CLUBS    | NINE OF DIAMONDS | NINE OF HEARTS   | NINE OF SPADES |
|  TEN OF CLUBS    |  TEN OF DIAMONDS |  TEN OF HEARTS   |  TEN OF SPADES |
| JACK OF CLUBS    | JACK OF DIAMONDS | JACK OF HEARTS   | JACK OF SPADES |
|QUEEN OF CLUBS    |QUEEN OF DIAMONDS |QUEEN OF HEARTS   |QUEEN OF SPADES |
| KING OF CLUBS    | KING OF DIAMONDS | KING OF HEARTS   | KING OF SPADES |
Press any key to continue . . .
**/