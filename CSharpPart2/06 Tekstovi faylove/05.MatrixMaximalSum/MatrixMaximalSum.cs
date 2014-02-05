/** 05. Write a program that reads a text file containing a square matrix of numbers            
        and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements.
        The first line in the input file contains the size of matrix N. 
        Each of the next N lines contain N numbers separated by space. 
        The output should be a single number in a separate text file.**/

using System;
using System.IO;

class MatrixMaximalSum
{
    // Define global variables
    static int areaSize = 2;
    static string fileName = @"../../matrix.txt";

    static void Main()
    {
        try
        {
            // Define instance for file reding
            StreamReader file = new StreamReader(fileName);
            
            using (file)
            {
                // Read first line, size of matrix
                int matrixSize = int.Parse(file.ReadLine());

                // Define the matrix with given size
                int[,] matrix = new int[matrixSize, matrixSize];

                // Reads lines from file and put the valus of them to the matrix
                for (int counter = 0; counter < matrixSize; counter++)
                {
                    string lines = file.ReadLine();
                    string[] linesAsStr = lines.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

                    for (int subCount = 0; subCount < matrixSize; subCount++)
                    {
                        matrix[counter, subCount] = int.Parse(linesAsStr[subCount]);
                    }
                }
            
            Console.WriteLine("In the matrix:\n");

            // Prints the matrix
            PrintMatrix(matrix);

            // Get maximal sub sum and print it.
            Console.WriteLine("\nMaximal sub sum is {0}.", GetMaxSum(matrix));
            }
        }
        catch { Console.WriteLine("File do not exist!"); }
    }

    // Prints matrix to console
    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col].ToString().PadLeft(3, ' '));
            }

            Console.WriteLine();
        }
    }

    static int GetMaxSum(int[,] matrix)
    {
        int maxSum = int.MinValue;

        // Loop for matrix
        for (int row = 0; row < matrix.GetLength(0) - areaSize + 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - areaSize + 1; col++)
            {
                int subSum = 0;
                
                // Loop for sub matrix to get current sub sum
                for (int subRow = row; subRow < row + areaSize; subRow++)
                {
                    for (int subCol = col; subCol < col + areaSize; subCol++)
                    {
                        subSum += matrix[subRow, subCol];
                    }
                }

                // Compare sub sums and exchange if needed.
                if (subSum > maxSum)
                {
                    maxSum = subSum;
                }
            }
        }
        
        // Return maximal sub sum
        return maxSum;
    }
}

/** Console output:
In the matrix:

  1  2  3  4
  5  6  7  8
  9 10 11 12
 13 14 15 16

Maximal sub sum is 54.
Press any key to continue . . .
 **/
