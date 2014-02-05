// 9. We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8 -> 1+1-2=0.

using System;

class SumIs0
{
    static void Main()
    {
        // Initialise the colection of 4 elements
        int[] collection = new int[5];
        bool zeroSum = false; // Default value of zeroSum
        Console.WriteLine("Enter 5 integers: ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("[{0}] = ", i+1);
            collection[i] = int.Parse(Console.ReadLine()); // Reads the elements of colection
        }

        for (int by1 = 0; by1 < 5; by1++)                       // loop 1
        {
            for (int by2 = 0; by2 < 5; by2++)                   // loop 2 for sub sum of 2 elements
            {
                for (int by3 = 0; by3 < 5; by3++)               // loop 3 for sub sum of 3 elements
                {
                    for (int by4 = 0; by4 < 5; by4++)           // loop 4 for sub sum of 4 elements
                    {
                        for (int by5 = 0; by5 < 5; by5++)       // loop 5 for sub sum of 5 elements
                        {
                            if ((collection[by1] + collection[by2] + collection[by3] + collection[by4] + collection[by5] == 0)  // Check the sum only if
                                && (by1 != by2) && (by1!= by3) && (by1!= by4) && (by1 != by5)                                   // by1 != by2 != by3 != by4 != by5
                                    && (by2 != by3) && (by2 != by4) && (by2 != by5)                                             // 
                                        && (by3 != by4) && (by3 != by5)                                                         //
                                            && (by4 != by5)                                                                     //    
                                                && (by1 < by2) && (by2 < by3) && (by3 < by4) && (by4 < by5))                    // by1 < by2 < by3 < by4 < by5
                            {
                                zeroSum = true;
                                // Print elements of subsum = 0
                                Console.WriteLine("{0}, {1}, {2}, {3}, {4} = 0", collection[by1], collection[by2], collection[by3], collection[by4], collection[by5]);
                                break;
                            }
                        }
                        if ((collection[by1] + collection[by2] + collection[by3] + collection[by4] == 0)    // Check the sum only if
                            && (by1 != by2) && (by1 != by3) && (by1 != by4)                                 // by1 != by2 != by3 != by4
                                && (by2 != by3) && (by2 != by4)                                             // 
                                    && (by3 != by4)                                                         //
                                        && (by1 < by2) && (by2 < by3) && (by3 < by4))                       // by1 < by2 < by3 < by4  
                        {                                                                                    
                            zeroSum = true;
                            // Print elements of subsum = 0
                            Console.WriteLine("{0}, {1}, {2}, {3} = 0", collection[by1], collection[by2], collection[by3], collection[by4]);
                            break;
                        }
                    }
                    if ((collection[by1] + collection[by2] + collection[by3] == 0)  // Check the sum only if
                        && (by1 != by2) && (by1 != by3)                             // by1 != by2 != by3
                            && (by2 != by3)                                         //
                                && (by1 < by2) && (by2 < by3))                      // by1 < by2 < by3
                    {                                                                
                        zeroSum = true;
                        // Print elements of subsum = 0
                        Console.WriteLine("{0}, {1}, {2} = 0", collection[by1], collection[by2], collection[by3]);
                        break;
                    }
                }
                if ((collection[by1] + collection[by2] == 0)    // Check the sum only if
                    && (by1 != by2)                             // by1 != by2
                        && (by1 < by2))                         // by1 < by2
                {                                              
                    zeroSum = true;
                    // Print elements of subsum = 0
                    Console.WriteLine("{0}, {1} = 0", collection[by1], collection[by2]);
                    break;
                }
            }
        }
        
        // Print the result on the console
        if (zeroSum)
        {
            Console.WriteLine("Exist zero sub sum!");
        }
        else
        {
            Console.WriteLine("NO zero sub sum!");
        }
    }
}

/** Console output:
Enter 5 integers:
[1] = 1
[2] = 2
[3] = -3
[4] = 3
[5] = -3
1, 2, -3, 3, -3 = 0
1, 2, -3 = 0
-3, 3 = 0
3, -3 = 0
Exist zero sub sum!
Press any key to continue . . .
**/