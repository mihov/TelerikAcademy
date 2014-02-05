using System;

namespace _03.JoroTheRabbit
{
    class JoroTheRabbit
    {
        static void Main()
        {
            string[] terrainTokens = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] terrainNumbers = new int[terrainTokens.Length];

            for (int counter = 0; counter < terrainTokens.Length; counter++)
            {
                terrainNumbers[counter] = int.Parse(terrainTokens[counter]);
            }

            int length = terrainNumbers.Length;
            int currentLength = 0;
            int maxLength = int.MinValue;

            for (int index = 0; index < length; index++)
            {

                for (int step = 1; step <= length; step++)
                {

                    int innerIndex = index;

                    while (true)
                    {
                        int oldPositionValue = terrainNumbers[innerIndex];
                        innerIndex += step;

                        currentLength++;

                        if (innerIndex >= length)
                        {
                            innerIndex -= length;
                        }

                        if (terrainNumbers[innerIndex] <= oldPositionValue)
                        {

                            if (currentLength > maxLength)
                            {
                                maxLength = currentLength;
                            }
                            currentLength = 0;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(maxLength);

        }
    }
}
