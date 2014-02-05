// 4.9. Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;
using System.Numerics;

class Fibonacci100
{
    static void Main()
    {
        int membersCount = 100; // Define how many members.
        int pad = membersCount / 5 + 1; // Define padding

        BigInteger memberNm2 = 0; // First and second members are fixsed 0 and 1
        BigInteger memberNm1 = 1; //
        BigInteger memberN;

        Console.WriteLine("[001] => {0}", memberNm2.ToString().PadLeft(pad, ' ')); // Print first and second members
        Console.WriteLine("[002] => {0}", memberNm1.ToString().PadLeft(pad, ' ')); //
        for (int fibunacciMember = 3; fibunacciMember <= 100; fibunacciMember++)    // Loop for the remaining  100 - 2 members
        {
            memberN = memberNm1 + memberNm2;    // Calculate member N
            memberNm2 = memberNm1;              // Assign value for N-2 member
            memberNm1 = memberN;                // Assign value for N-1 member

            // Print member count and member in friendly format
            Console.WriteLine("[{0}] => {1}", fibunacciMember.ToString().PadLeft(3, '0'), memberN.ToString().PadLeft(pad, ' '));
        }

    }
}
/** Console Output:
[001] =>                     0
[002] =>                     1
[003] =>                     1
[004] =>                     2
..............................
[096] =>  31940434634990099905
[097] =>  51680708854858323072
[098] =>  83621143489848422977
[099] => 135301852344706746049
[100] => 218922995834555169026
Press any key to continue . . .
**/