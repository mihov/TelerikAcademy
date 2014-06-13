using System;

namespace Task04
{
    class Task03
    {
        public void Task03()
        {
            int maxValue = 100;
            int expectedValue = 50;
            int[] array = new int[maxValue];
            int evilNumber = 666;
            int divisor = 10;

            for (int i = 0; i < maxValue; i++)
            {
                if (i % divisor == 0)
                {
                    Console.WriteLine(array[i]);
                    if (array[i] == expectedValue)
                    {
                        i = evilNumber;
                    }
                }
                else
                {
                    Console.WriteLine(array[i]);
                }

                if (i == evilNumber)
                {
                    Console.WriteLine("Value Found");
                }
            }
        }
    }
}