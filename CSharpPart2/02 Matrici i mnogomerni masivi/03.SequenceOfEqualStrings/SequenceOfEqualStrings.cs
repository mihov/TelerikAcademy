// 03. We are given a matrix of strings of size N x M.
// Sequences in the matrix we define as sets of several neighbor elements
// located on the same line, column or diagonal.
// Write a program that finds the longest sequence of equal strings in the matrix.
// Example:
/**
 *  ha  fifi    ho  hi  |                   s   qq  s   |
 *  fo  ha      hi  xx  |->ha, ha, ha       pp  pp  s   |->s,s,s
 *  xxx ho      ha  xx  |                   pp  qq  s   |
 **/

using System;

class SequenceOfEqualStrings
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

        // Declare the matrix
        string[,] matrix;

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

        PrintMatrixMaxSequence(matrix);
    }

    /// <summary>
    /// Fill given array manually
    /// </summary>
    /// <param name="row">Number of rows.</param>
    /// <param name="column">Numbers of columns.</param>
    /// <returns>Array with manual values</returns>
    static string[,] FillMatrixManual(int row, int column)
    {

        string[,] theMatrix = new string[row, column];

        // Loop for all matrix cells
        Console.WriteLine("\nEnter the matrix elements:");

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                Console.Write("[{0},{1}] = ", i, j);
                // Fill current cell with value
                theMatrix[i, j] = Console.ReadLine();
            }
        }
        return theMatrix;
    }

    /// <summary>
    /// Fill given array with random values
    /// </summary>
    /// <param name="row">Number of rows.</param>
    /// <param name="column">Numbers of columns.</param>
    /// <returns>Array with random values</returns>
    static string[,] FillMatrixRandom(int row, int column)
    {
        Random rnd = new Random();

        string[,] theMatrix = new string[row, column];

        // Loop for all matrix cells
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                // Fill current cell with random value
                theMatrix[i, j] = ((char)rnd.Next(65, 68)).ToString() + ((char)rnd.Next(65, 68)).ToString();
            }
        }
        return theMatrix;
    }

    /// <summary>
    /// Prints given array
    /// </summary>
    /// <param name="matrix">String array.</param>
    static void PrintMatrix(string[,] matrix)
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

    /// <summary>
    /// Prints maximal sequence of equal strings from given matrix. 
    /// </summary>
    /// <param name="matrix">String array.</param>
    static void PrintMatrixMaxSequence(string[,] matrix)
    {
        string maxSequenceString = "";
        int maxSequenceLength = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int maxSequenceLengthCandidate =
                           StringUpCount(matrix, row, col) + StringDownCount(matrix, row, col) +
                           StringLeftCount(matrix, row, col) + StringRightCount(matrix, row, col) +
                           StringDownLeftCount(matrix, row, col) + StringDownRightCount(matrix, row, col) +
                           StringUpLeftCount(matrix, row, col) + StringUpRightCount(matrix, row, col) + 1;

                if (maxSequenceLengthCandidate > maxSequenceLength)
                {
                    // Set new value for maximal sequence length
                    maxSequenceLength = maxSequenceLengthCandidate;
                    maxSequenceString = matrix[row, col];
                }
            }
        }
        
        // Prints the sequence. 
        Console.Write ("The sequence is: ");
        for (int counter = 1; counter <= maxSequenceLength; counter++)
        {
            Console.Write(maxSequenceString);
            if (counter < maxSequenceLength)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }

    /// <summary>
    /// Returns the count of elements up from the current. 
    /// </summary>
    /// <param name="matrix">String array.</param>
    /// <param name="row">Current row.</param>
    /// <param name="col">Current column</param>
    /// <returns>Count of equal strings up from the current.</returns>
    static int StringUpCount(string[,] matrix, int row, int col)
    {
        string pattern = matrix[row, col];
        int sum = 0;

        for (int up = row - 1; up >= 0; up--)
        {
            if (matrix[up, col] == pattern)
            {
                sum++;
            }
            else
            {
                break;
            }
        }
        return sum;
    }

    /// <summary>
    /// Returns the count of elements down from the current. 
    /// </summary>
    /// <param name="matrix">String array.</param>
    /// <param name="row">Current row.</param>
    /// <param name="col">Current column</param>
    /// <returns>Count of equal strings down from the current.</returns>
    static int StringDownCount(string[,] matrix, int row, int col)
    {
        string pattern = matrix[row, col];
        int sum = 0;

        for (int down = row + 1; down < matrix.GetLength(0); down++)
        {
            if (matrix[down, col] == pattern)
            {
                sum++;
            }
            else
            {
                break;
            }
        }
        return sum;
    }

    /// <summary>
    /// Returns the count of elements left from the current. 
    /// </summary>
    /// <param name="matrix">String array.</param>
    /// <param name="row">Current row.</param>
    /// <param name="col">Current column</param>
    /// <returns>Count of equal strings left from the current.</returns>
    static int StringLeftCount(string[,] matrix, int row, int col)
    {
        string pattern = matrix[row, col];
        int sum = 0;

        for (int left = col - 1; left >= 0; left--)
        {
            if (matrix[row, left] == pattern)
            {
                sum++;
            }
            else
            {
                break;
            }
        }
        return sum;
    }

    /// <summary>
    /// Returns the count of elements right from the current. 
    /// </summary>
    /// <param name="matrix">String array.</param>
    /// <param name="row">Current row.</param>
    /// <param name="col">Current column</param>
    /// <returns>Count of equal strings right from the current.</returns>
    static int StringRightCount(string[,] matrix, int row, int col)
    {
        string pattern = matrix[row, col];
        int sum = 0;

        for (int right = col + 1; right < matrix.GetLength(1); right++)
        {
            if (matrix[row, right] == pattern)
            {
                sum++;
            }
            else
            {
                break;
            }
        }
        return sum;
    }

    /// <summary>
    /// Returns the count of elements UpRight from the current. 
    /// </summary>
    /// <param name="matrix">String array.</param>
    /// <param name="row">Current row.</param>
    /// <param name="col">Current column</param>
    /// <returns>Count of equal strings UpRight from the current.</returns>
    static int StringUpRightCount(string[,] matrix, int row, int col)
    {
        string pattern = matrix[row, col];
        int sum = 0;

        // Set start position
        int up = row - 1;
        int right = col + 1;

        while (right < matrix.GetLength(1) && up >= 0)
        {
            if (matrix[up, right] == pattern)
            {
                sum++;
                
                // Next cell
                right++;
                up--;
            }
            else
            {
                break;
            }
        }
        return sum;
    }

    /// <summary>
    /// Returns the count of elements UpLeft from the current. 
    /// </summary>
    /// <param name="matrix">String array.</param>
    /// <param name="row">Current row.</param>
    /// <param name="col">Current column</param>
    /// <returns>Count of equal strings UpLeft from the current.</returns>
    static int StringUpLeftCount(string[,] matrix, int row, int col)
    {
        string pattern = matrix[row, col];
        int sum = 0;

        // Set start position
        int up = row - 1;
        int left = col - 1;

        while (left >= 0 && up >= 0)
        {
            if (matrix[up, left] == pattern)
            {
                sum++;

                // Next cell
                left--;
                up--;
            }
            else
            {
                break;
            }
        }
        return sum;
    }

    /// <summary>
    /// Returns the count of elements DownLeft from the current. 
    /// </summary>
    /// <param name="matrix">String array.</param>
    /// <param name="row">Current row.</param>
    /// <param name="col">Current column</param>
    /// <returns>Count of equal strings DownLeft from the current.</returns>
    static int StringDownLeftCount(string[,] matrix, int row, int col)
    {
        string pattern = matrix[row, col];
        int sum = 0;
        
        // Set start position
        int down = row + 1;
        int left = col - 1;

        while (left >= 0 && down < matrix.GetLength(0))
        {
            if (matrix[down, left] == pattern)
            {
                sum++;

                // Next cell
                left--;
                down++;
            }
            else
            {
                break;
            }
        }
        return sum;
    }

    /// <summary>
    /// Returns the count of elements DownRight from the current. 
    /// </summary>
    /// <param name="matrix">String array.</param>
    /// <param name="row">Current row.</param>
    /// <param name="col">Current column</param>
    /// <returns>Count of equal strings DownRight from the current.</returns>
    static int StringDownRightCount(string[,] matrix, int row, int col)
    {
        string pattern = matrix[row, col];
        int sum = 0;

        // Set start position
        int down = row + 1;
        int right = col + 1;

        while (right < matrix.GetLength(1) && down < matrix.GetLength(0))
        {
            if (matrix[down, right] == pattern)
            {
                sum++;

                // Next cell
                right++;
                down++;
            }
            else
            {
                break;
            }
        }
        return sum;
    }
}

/** Console output:
Enter the size of the matrix.
N = 3
M = 4


[M]anula or [A]utomatic matrix filling? m

Enter the matrix elements:
[0,0] = ha
[0,1] = fifi
[0,2] = ho
[0,3] = hi
[1,0] = fo
[1,1] = ha
[1,2] = hi
[1,3] = xx
[2,0] = xxx
[2,1] = ho
[2,2] = ha
[2,3] = xx

The matrix is:

  hafifi  ho  hi
  fo  ha  hi  xx
 xxx  ho  ha  xx

The sequence is: ha, ha, ha
Press any key to continue . . .


**/