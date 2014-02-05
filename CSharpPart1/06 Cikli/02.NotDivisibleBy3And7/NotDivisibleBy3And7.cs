// 2. Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

using System;

class NotDivisibleBy3And7
{
    static void Main()
    {
        Console.Write("Enter N (N > 1): ");
        int numbersN = int.Parse(Console.ReadLine());           // Read N from console
        for (int counter = 1; counter <= numbersN; counter++)   // Loop from 1 to N
        {
            if ((counter % 3 != 0) || (counter % 7 != 0))       //Check divisiblity by 3 and 7 at the same time
            {
                Console.WriteLine(counter);                     // Print from 1 to N that are not divisible by 3 and 7 at the same time on the console
            }
                                     
        }
    }
}

/** Console output:
Enter N (N > 1): 25
1
2
3
4
5
6
7
8
9
10
11
12
13
14
15
16
17
18
19
20
22
23
24
25
Press any key to continue . . .
 **/
