﻿// 14. Write a program that reads a positive integer number N (N < 20) from console
// and outputs in the console the numbers 1 ... N numbers arranged as a spiral.

using System;

class Spiral
{
    static void Main()
    {
        Console.Write("Enter a N where 0 < N < 20: ");
        int numberN;
        if (int.TryParse(Console.ReadLine(), out numberN) && numberN > 0 && numberN < 20) // Read N from console, Parse it and check it
        {
            int[,] matrix = new int[numberN, numberN];                              // Declare the matrix
            int element = 1;
            int indexOfRow = 0;
            int indexOfColumn = 0;
            int maxIndexOfRow = numberN - 1;
            int maxIndexOfColumn = numberN - 1;

            // Loop from 1 to N
            do
            {
                for (int i = indexOfColumn; i <= maxIndexOfColumn; i++)             // Go right
                {
                    matrix[indexOfRow, i] = element;
                    element++;                                                      // next element
                }
                indexOfRow++;
                for (int i = indexOfRow; i <= maxIndexOfRow; i++)                   // Go down
                {
                    matrix[i, maxIndexOfColumn] = element;
                    element++;                                                      // next element
                }
                maxIndexOfColumn--;
                for (int i = maxIndexOfColumn; i >= indexOfColumn; i--)             // Go left
                {
                    matrix[maxIndexOfRow, i] = element;
                    element++;                                                      // next element
                }
                maxIndexOfRow--;
                for (int i = maxIndexOfRow; i >= indexOfRow; i--)                   // Go up
                {
                    matrix[i, indexOfColumn] = element;
                    element++;                                                      // next element
                }
                indexOfColumn++;
            }
            while (element <= numberN * numberN);                                   // Loop ends if current element = N*N

            // Print the matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("|");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j].ToString().PadLeft(element.ToString().Length, ' ') + "|");
                }
                Console.WriteLine();
            }
        }
    }
}

/** Console output:
Enter a N where 0 < N < 20: 19
|  1|  2|  3|  4|  5|  6|  7|  8|  9| 10| 11| 12| 13| 14| 15| 16| 17| 18| 19|
| 72| 73| 74| 75| 76| 77| 78| 79| 80| 81| 82| 83| 84| 85| 86| 87| 88| 89| 20|
| 71|136|137|138|139|140|141|142|143|144|145|146|147|148|149|150|151| 90| 21|
| 70|135|192|193|194|195|196|197|198|199|200|201|202|203|204|205|152| 91| 22|
| 69|134|191|240|241|242|243|244|245|246|247|248|249|250|251|206|153| 92| 23|
| 68|133|190|239|280|281|282|283|284|285|286|287|288|289|252|207|154| 93| 24|
| 67|132|189|238|279|312|313|314|315|316|317|318|319|290|253|208|155| 94| 25|
| 66|131|188|237|278|311|336|337|338|339|340|341|320|291|254|209|156| 95| 26|
| 65|130|187|236|277|310|335|352|353|354|355|342|321|292|255|210|157| 96| 27|
| 64|129|186|235|276|309|334|351|360|361|356|343|322|293|256|211|158| 97| 28|
| 63|128|185|234|275|308|333|350|359|358|357|344|323|294|257|212|159| 98| 29|
| 62|127|184|233|274|307|332|349|348|347|346|345|324|295|258|213|160| 99| 30|
| 61|126|183|232|273|306|331|330|329|328|327|326|325|296|259|214|161|100| 31|
| 60|125|182|231|272|305|304|303|302|301|300|299|298|297|260|215|162|101| 32|
| 59|124|181|230|271|270|269|268|267|266|265|264|263|262|261|216|163|102| 33|
| 58|123|180|229|228|227|226|225|224|223|222|221|220|219|218|217|164|103| 34|
| 57|122|179|178|177|176|175|174|173|172|171|170|169|168|167|166|165|104| 35|
| 56|121|120|119|118|117|116|115|114|113|112|111|110|109|108|107|106|105| 36|
| 55| 54| 53| 52| 51| 50| 49| 48| 47| 46| 45| 44| 43| 42| 41| 40| 39| 38| 37|
Press any key to continue . . .
**/