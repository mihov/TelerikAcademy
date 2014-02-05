// You should print the fire on the console. Use the symbol “#” (number sign) to mark the fire,
// “-“ (dash) to show the top of the torch and “/” (slash) or “\” (backslash) to illustrate the torch.
// Constraints •	N will be a positive integer in the range [4…76] and will always be divisible by 4.


using System;

class fire
{
    static void Main()
    {
        int columnsN = int.Parse(Console.ReadLine());
        int rows = columnsN / 2 + columnsN / 4 + 1 + columnsN / 2;

        char[,] fire = new char[rows + 1, columnsN + 1];

        // Fill with '.'
        for (int row = 1; row <= rows; row++)
        {
            for (int column = 1; column <= columnsN; column++)
            {
                fire[row, column] = '.';
            }
        }

        // Put mark '-'
        for (int i = 1; i <= columnsN; i++)
        {
            fire[columnsN / 2 + columnsN / 4 + 1, i] = '-';
        }

        //up fire
        for (int row = 1; row <= columnsN / 2; row++)
        {
            fire[row, (row + columnsN / 2)] = '#';
            fire[row, (columnsN / 2 - row + 1)] = '#';
        }

        // down fire
        for (int row = 1; row <= columnsN / 4; row++)
        {
            fire[(row + columnsN / 2), row] = '#';
            fire[(row + columnsN / 2), columnsN + 1 - row] = '#';
        }

        // torch left
        for (int row = 1; row <= columnsN / 2; row++)
        {
            for (int col = row; col <= columnsN /2; col++)
            {
                fire[row + columnsN / 2 + columnsN / 4 + 1, col] = '\\';
                fire[row + columnsN / 2 + columnsN / 4 + 1, columnsN - col +1] = '/';
            }

        }





        // Print fire
        for (int row = 1; row <= rows; row++)
        {
            for (int column = 1; column <= columnsN; column++)
            {
                Console.Write(fire[row, column]);
            }
            Console.WriteLine();
        }

    }
}