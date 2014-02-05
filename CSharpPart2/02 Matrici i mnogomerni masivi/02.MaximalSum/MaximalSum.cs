// 02. Write a program that reads a rectangular matrix of size N x M
// and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class MaximalSum
{
    static void Main()
    {
        // Reads the matrix dimensions
        Console.Write("Enter the size of the matrix.\nN = ");
        int matrixSizeN;
        if (!int.TryParse(Console.ReadLine(), out matrixSizeN))
        {
            // Error message and exit
            Console.WriteLine("Incorrect value!");
            return;
        }

        Console.Write("M = ");
        int matrixSizeM;
        if (!int.TryParse(Console.ReadLine(), out matrixSizeM))
        {
            // Error message and exit
            Console.WriteLine("Incorrect value!");
            return;
        }

        Console.WriteLine();

        // Reads size of square
        Console.Write("Size of square (less than {0}) = ", Math.Min(matrixSizeM, matrixSizeN));
        int squareSize;
        if (!int.TryParse(Console.ReadLine(), out squareSize) || squareSize > Math.Min(matrixSizeM, matrixSizeN))
        {
            // Error message and exit
            Console.WriteLine("Incorrect value!");
            return;
        }

        // Declare the matrix
        int[,] matrix;

        Console.WriteLine();

        // Menu selector Manual or Automatic matrix filling
        Console.Write("[M]anula or [A]utomatic matrix filling? ");
        switch (Console.ReadLine())
        {
            case "M":
            case "m":

                // Fill the matrix manual
                matrix = FillMatrixManual(matrixSizeN, matrixSizeM);
                break;

            case "A":
            case "a":

                // Fill the matrix automatic
                matrix = FillMatrixRandom(matrixSizeN, matrixSizeM);
                break;

            default:
                Console.WriteLine("Incorrect value!");
                return;
        }

        // Prints filled matrix
        Console.WriteLine("\nThe matrix is:");
        PrintMatrix(matrix);

        int maxSubRow;
        int maxSubCol;

        // Calculates the maximum sum of the square submatrix and its coordinates. 
        int maxSum = SubMatrixMaxSum(matrix, squareSize, out maxSubRow, out maxSubCol);

        // Prints maximal sum
        Console.WriteLine("Maximal sum is {0}.", maxSum);

        // Prints the square submatrix with the maximum sum
        Console.WriteLine("\nSub matrix is:");
        PrintSubMatrix(matrix, maxSubRow, maxSubCol, squareSize);

    }

    // Calculates the maximum sum of the square submatrix and its coordinates. 
    static int SubMatrixMaxSum(int[,] matrix, int size, out int maxSubRow, out int maxSubCol)
    {
        int maxSum = 0;
        int maxSumCandidate = 0;
        
        maxSubRow = 0;
        maxSubCol = 0;

        for (int row = 0; row <= matrix.GetLength(0) - size; row++)
        {
            for (int col = 0; col <= matrix.GetLength(1) - size; col++)
            {
                // Sum of the current square
                maxSumCandidate = SubSum(matrix, row, col, size);

                // New value for the maximal sum
                if (maxSumCandidate > maxSum)
                {
                    maxSum = maxSumCandidate;
                    maxSubRow = row;
                    maxSubCol = col;
                }
            }
        }
        return maxSum;
    }

    // Calculates the sum of the square elements from given matrix and size of square
    static int SubSum(int[,] matrix, int row, int column, int size)
    {
        int sum = 0;
        
        for (int currenrRow = row; currenrRow < row + size; currenrRow++)
        {
            for (int currentColumn = column; currentColumn < column + size; currentColumn++)
            {
                sum += matrix[currenrRow, currentColumn];
            }
        }

        return sum;
    }

    // Method Fill the matrix manual
    static int[,] FillMatrixManual(int row, int column)
    {

        int[,] theMatrix = new int[row, column];

        int temp;
        
        // Loop for all matrix cells
        Console.WriteLine("\nEnter the matrix elements:");
        
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                Console.Write("[{0},{1}] = ", i, j);
                // Fill current cell with random value
                if (int.TryParse(Console.ReadLine(), out temp))
                {
                    theMatrix[i, j] = temp;
                }
                else
                {
                    // Fills with 0 if unable to parse.
                    theMatrix[i, j] = 0;
                }
            }
        }
        return theMatrix;
    }

    // Method Fill the matrix with random values
    static int[,] FillMatrixRandom(int row, int column)
    {
        Random rnd = new Random();

        int[,] theMatrix = new int[row, column];

        // Loop for all matrix cells
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                // Fill current cell with random value
                theMatrix[i, j] = rnd.Next(1, row * column);
            }
        }
        return theMatrix;
    }

    // Method prints the matrix
    static void PrintMatrix(int[,] matrix)
    {
        Console.WriteLine();
        // Loop for all elements of the matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                // Print the current element of the matrix 
                Console.Write("{0}", matrix[row, col].ToString().PadLeft(4, ' '));
            }
            // Go to next line
            Console.WriteLine();
        }
        // Print an empty line
        Console.WriteLine();
    }

    //
    static void PrintSubMatrix(int[,] matrix, int subRow, int subColumn, int size)
    {
        Console.WriteLine();
        // Loop for all elements of the matrix
        for (int row = subRow; row < subRow + size; row++)
        {
            for (int col = subColumn; col < subColumn + size; col++)
            {
                // Print the current element of the matrix 
                Console.Write("{0}", matrix[row, col].ToString().PadLeft(4, ' '));
            }
            // Go to next line
            Console.WriteLine();
        }
        // Print an empty line
        Console.WriteLine();
    }
}

/** Console output:
 * Automatic filling
Enter the size of the matrix.
N = 10
M = 10

Size of square (less than 10) = 3

[M]anula or [A]utomatic matrix filling? A

The matrix is:

  23  13  85  29  73  60  19  65  25  51
  20  32  34  12  54  28  44  54  44  49
  76  96  31  16  65  35   4  55  59  60
   9  98  38  92  52  26  50  82  79  44
  35  11   2  57  83  36  47   1  92   4
  38  68  85  58  58  26  82  70  63  38
  57  64   7  64  42  22  93  41  59  28
  78  62  75   1  14  65  94  73  32  30
  87   3  63  55  23  41  13  79  35  27
  44  79  19  41  86  70   4  37  15  62

Maximal sum is 607.

Sub matrix is:

  82  70  63
  93  41  59
  94  73  32

Press any key to continue . . .
 *
 * 
 * Manual filling
 * 
Enter the size of the matrix.
N = 4
M = 4

Size of square (less than 4) = 3

[M]anula or [A]utomatic matrix filling? M

Enter the matrix elements:
[0,0] = 1
[0,1] = 2
[0,2] = 3
[0,3] = 4
[1,0] = 5
[1,1] = 6
[1,2] = 7
[1,3] = 8
[2,0] = 9
[2,1] = 10
[2,2] = 11
[2,3] = 12
[3,0] = 13
[3,1] = 14
[3,2] = 15
[3,3] = 16

The matrix is:

   1   2   3   4
   5   6   7   8
   9  10  11  12
  13  14  15  16

Maximal sum is 99.

Sub matrix is:

   6   7   8
  10  11  12
  14  15  16

Press any key to continue . . .
 **/
