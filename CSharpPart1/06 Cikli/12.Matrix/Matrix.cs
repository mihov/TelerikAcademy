// 11. Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:

using System;

class Matrix
{
    static void Main()
    {
        Console.Write("Enter number of rows/columns of the matrix (N < 20): ");
        int elements;
        if (int.TryParse(Console.ReadLine(), out elements) && elements > 0 && elements < 20) // Read N and check is 0 < N < 20
        {
            Console.WriteLine();
            for (int row = 1; row <= elements; row++)   // Loop for rows
            {
                Console.Write("|"); // Print Left Border
                for (int column = row; column < (row + elements); column++)     // Loop for columns
                {
                    Console.Write("{0}|", column.ToString().PadLeft(2,' '));    // Print element and border
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Not meet the requirements!");                    // Error message
        }
    }
}

/** Console output
Enter number of rows/columns of the matrix (N < 20): 19

| 1| 2| 3| 4| 5| 6| 7| 8| 9|10|11|12|13|14|15|16|17|18|19|
| 2| 3| 4| 5| 6| 7| 8| 9|10|11|12|13|14|15|16|17|18|19|20|
| 3| 4| 5| 6| 7| 8| 9|10|11|12|13|14|15|16|17|18|19|20|21|
| 4| 5| 6| 7| 8| 9|10|11|12|13|14|15|16|17|18|19|20|21|22|
| 5| 6| 7| 8| 9|10|11|12|13|14|15|16|17|18|19|20|21|22|23|
| 6| 7| 8| 9|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|
| 7| 8| 9|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|
| 8| 9|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|
| 9|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|
|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|
|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|
|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|
|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|
|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|
|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|
|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|
|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|
|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36|
|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36|37|
Press any key to continue . . .
**/