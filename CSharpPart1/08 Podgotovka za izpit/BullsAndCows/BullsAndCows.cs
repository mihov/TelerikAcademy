using System;

class BullsAndCows
{
    static void Main()
    {
        String secretNumber = Console.ReadLine();
        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());

        for (int guessNumber = 1111; guessNumber <= 9999; guessNumber++)
        {
            string guessNumberStr = guessNumber.ToString();
            char[] secretNumberChar = new char[4];
            for (int i = 0; i <= 3; i++)
            {
                secretNumberChar[i] = secretNumber[i];
            }

            int bullsCount = 0;
            for (int iBulls = 0; iBulls <= 3; iBulls++)
            {
                if (guessNumberStr[iBulls] == secretNumberChar[iBulls])
                {
                    bullsCount++;
                    secretNumberChar[iBulls] = '0';
                }
            }

            int cowCount = 0;
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    if ((int)guessNumberStr[j] == (int)secretNumberChar[i])
                    {
                        cowCount++;
                        secretNumberChar[i] = '0';
                    }
                }
            }
            if ((bullsCount == bulls) && (cowCount == cows))
            {
                Console.Write("{0} ", guessNumber);
            }
        }
    }
}
