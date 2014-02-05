// 01. Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
/**
     a) 1   5   9   13               b) 1   8   9   16
        2   6   10  14                  2   7   10  15
        3   7   11  15                  3   6   11  14
        4   8   12  16                  4   5   12  13

     c) 7   11  14  16               d) 1   12  11  10
        4   8   12  15                  2   13  16  9
        2   5   9   13                  3   14  15  8
        1   3   6   10                  4   5   6   7
**/
using System;

class FillAndPrint
{
    static void Main()
    {
        // Enter the matrix dimensions
        Console.Write("Enter the size of the matrix: ");
        int matrixSize;
        if (!int.TryParse(Console.ReadLine(), out matrixSize))
        {
            // Error message and exit
            Console.WriteLine("Unable to parse!");
            return;
        }

        // Enter path to fill the matrix
        Console.Write("Choose the pattern (a, b, c, d or All): ");
        string pattern = Console.ReadLine();
        Console.WriteLine();

        // Menu selector
        switch (pattern)
        {
            case "a":
                PrintMatrix(DrawA(matrixSize));                     // Fill and print by pattern a).
                break;

            case "b":
                PrintMatrix(DrawB(matrixSize));                     // Fill and print by pattern b).
                break;

            case "c":
                PrintMatrix(DrawC(matrixSize));                     // Fill and print by pattern c).
                break;

            case "d":
                PrintMatrix(DrawD(matrixSize));                     // Fill and print by pattern d).
                break;

            case "All":
                PrintMatrix(DrawA(matrixSize));                     // Fill and print by all patterns.
                PrintMatrix(DrawB(matrixSize));
                PrintMatrix(DrawC(matrixSize));
                PrintMatrix(DrawD(matrixSize));
                break;

            default:
                Console.WriteLine("Path {0} do not exist!", pattern);  // Error message.
                break;
        }
    }

    // Method prints the matrix
    static void PrintMatrix(int[,] matrix)
    {
        // Calculate the size of the matrix
        int size = (int)Math.Sqrt(matrix.Length);

        // Loop for all elements of the matrix
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
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

    // Fill the matrix by pattern a).
    static int[,] DrawA(int size)
    {
        // Calculate matrix elements
        int elements = size * size;

        // Create an empty matrix
        int[,] theMatrix = new int[size, size];

        // Set strat position
        int row = 0;
        int col = 0;
        int counter = 0;

        while (counter < elements)
        {
            // Fill current cell
            theMatrix[row, col] = counter + 1;

            // Go to next element and row
            counter++;
            row++;

            // Reach the end of the row 
            if (counter % size == 0)
            {
                // Go to top
                row = 0;

                // Go to next column
                col++;
            }
        }
        return theMatrix;
    }

    // Fill the matrix by pattern b).
    static int[,] DrawB(int size)
    {
        // Calculate matrix elements
        int elements = size * size;

        // Create an empty matrix
        int[,] theMatrix = new int[size, size];

        // Set strat position and direction
        int row = 0;
        int col = 0;
        int counter = 0;
        char direction = 'D'; // U = Up or D = Down


        while (counter < elements)
        {
            // Fill current cell 
            theMatrix[row, col] = counter + 1;

            // Next element
            counter++;

            if (direction == 'D')
            {
                // Next down cell 
                row++;
            }
            else
            {
                // Next up cell
                row--;
            }

            // Reach the end of the row
            if (counter % size == 0)
            {
                col++;

                if (direction == 'D')
                {
                    // Change direction to down.
                    direction = 'U';
                    row--;
                }
                else
                {
                    // Change direction to down.
                    direction = 'D';
                    row++;
                }
            }
        }

        return theMatrix;
    }

    // Fill the matrix by pattern c).
    static int[,] DrawC(int size)
    {
        // Calculate elements of the matrix
        int elements = size * size;

        // Define the matrix
        int[,] theMatrix = new int[size, size];

        // Set start position
        int row = size - 1;
        int col = 0;
        int counter = 1;

        while (counter <= elements)
        {
            // Fill current cell
            theMatrix[row, col] = counter;

            // Go to next elemet and cell
            counter++;
            col++;
            row++;

            // Diagonal reached 
            if (row == size && col == size)
            {
                // Move to proper cell
                row = 0;
                col = 1;
            }

            // Bottom reached
            if (row == size)
            {
                // Move to proper cell
                row = size - col - 1;
                col = 0;
            }

            // Right end reached
            if (col == size)
            {
                // Move to proper cell
                col = size - row + 1;
                row = 0;
            }
        }
        return theMatrix;
    }

    // Fill the matrix by pattern c).
    static int[,] DrawD(int size)
    {
        // Calculate elements of the matrix
        int elements = size * size;

        // Define the matrix
        int[,] theMatrix = new int[size, size];

        // Set start position and direction
        int row = 0;
        int col = 0;
        char direction = 'D';
        int counter = 1;

        while (counter <= elements)
        {
            // Fill current cell
            theMatrix[row, col] = counter;

            // Go to next element
            counter++;

            // Go to next proper cell in depend of current direction 
            switch (direction)
            {
                case 'D':
                    row++;
                    break;
                case 'L':
                    col--;
                    break;
                case 'U':
                    row--;
                    break;
                case 'R':
                    col++;
                    break;
                default:
                    break;
            }

            // Change the direction if edge of the matrix was reached or the cell is not empty.
            if ((row < 0) || (row == size) || (col < 0) || (col == size) || theMatrix[row, col] > 0)
            {
                switch (direction)
                {
                    case 'D':
                        row--;
                        col++;
                        direction = 'R';    // Change the direction to right
                        break;

                    case 'R':
                        col--;
                        row--;
                        direction = 'U';    // Change the direction to up
                        break;

                    case 'U':
                        row++;
                        col--;
                        direction = 'L';    // Change the direction to left
                        break;

                    case 'L':
                        row++;
                        col++;
                        direction = 'D';    // Change the direction to down
                        break;

                    default:
                        break;
                }
            }
        }

        return theMatrix;
    }
}

/** Console output:
Enter the size of the matrix: 10
Choose the pattern (a, b, c, d or All): All

   1  11  21  31  41  51  61  71  81  91
   2  12  22  32  42  52  62  72  82  92
   3  13  23  33  43  53  63  73  83  93
   4  14  24  34  44  54  64  74  84  94
   5  15  25  35  45  55  65  75  85  95
   6  16  26  36  46  56  66  76  86  96
   7  17  27  37  47  57  67  77  87  97
   8  18  28  38  48  58  68  78  88  98
   9  19  29  39  49  59  69  79  89  99
  10  20  30  40  50  60  70  80  90 100

   1  20  21  40  41  60  61  80  81 100
   2  19  22  39  42  59  62  79  82  99
   3  18  23  38  43  58  63  78  83  98
   4  17  24  37  44  57  64  77  84  97
   5  16  25  36  45  56  65  76  85  96
   6  15  26  35  46  55  66  75  86  95
   7  14  27  34  47  54  67  74  87  94
   8  13  28  33  48  53  68  73  88  93
   9  12  29  32  49  52  69  72  89  92
  10  11  30  31  50  51  70  71  90  91

  46  56  65  73  80  86  91  95  98 100
  37  47  57  66  74  81  87  92  96  99
  29  38  48  58  67  75  82  88  93  97
  22  30  39  49  59  68  76  83  89  94
  16  23  31  40  50  60  69  77  84  90
  11  17  24  32  41  51  61  70  78  85
   7  12  18  25  33  42  52  62  71  79
   4   8  13  19  26  34  43  53  63  72
   2   5   9  14  20  27  35  44  54  64
   1   3   6  10  15  21  28  36  45  55

   1  36  35  34  33  32  31  30  29  28
   2  37  64  63  62  61  60  59  58  27
   3  38  65  84  83  82  81  80  57  26
   4  39  66  85  96  95  94  79  56  25
   5  40  67  86  97 100  93  78  55  24
   6  41  68  87  98  99  92  77  54  23
   7  42  69  88  89  90  91  76  53  22
   8  43  70  71  72  73  74  75  52  21
   9  44  45  46  47  48  49  50  51  20
  10  11  12  13  14  15  16  17  18  19

Press any key to continue . . .
 **/
