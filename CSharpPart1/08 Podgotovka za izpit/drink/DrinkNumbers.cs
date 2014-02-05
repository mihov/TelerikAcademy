using System;

    class DrinkNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            
            for (int drunken = 0; drunken < n; drunken++)
            {

                int absNumber = int.Parse(Console.ReadLine());
                absNumber = Math.Abs(absNumber);
                string input = absNumber.ToString(); // remouve leading '0'

            
                for (int i = 0; i < (input.Length + 1)/2; i++)
                {
                    int digit = input[i] - '0';
                    leftSum += digit;
                }

           
                for (int i = (input.Length/2); i < input.Length; i++)
                {
                    int digit = input[i] - '0';
                    rightSum += digit;
                }   
            }
            if (leftSum < rightSum)
            {
                Console.WriteLine("V {0}", (rightSum-leftSum));
            }
            else if (leftSum > rightSum)
            {
              Console.WriteLine("M {0}", (leftSum-rightSum));  
            }
            else if (leftSum == rightSum)
            {
                Console.WriteLine("No {0}", rightSum + leftSum);
            }
        }
    }