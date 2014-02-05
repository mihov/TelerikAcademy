// 15. Write a program that finds all prime numbers in the range [1...10 000 000].
// Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

using System;
using System.Collections.Generic;

class PrimeNumbers
{
    static void Main()
    {
        int countTo = 10000000;

        // This array keeps, whether the item has been inspected.
        bool[] primeCheckArray = new bool[countTo + 1];// Default value is false.

        // List for all prime values  
        List<int> primeArray = new List<int>();      

        // One is prime
        primeArray.Add(1);

        // Loop from two to the end.
        for (int counter = 2; counter <= countTo; counter++)
        {
            // Is element was checked as Non prime
            if (!primeCheckArray[counter])
            {
                // Add current element to prime array
                primeArray.Add(counter); 
                
                // Loop from current element to the end, counter is incremented by current element
                for (int internCount = counter + counter; internCount <= countTo; internCount += counter)
                {
                    // Check current element as non prime
                    primeCheckArray[internCount] = true;
                }
            }
        }

        // Print prime array to console
        for (int counter = 0; counter < primeArray.Count; counter++)
        {
            // Print current element 
            Console.Write(primeArray[counter].ToString().PadLeft(8,' '));

            // Define number of columns and rows to be displayed. 
            int col = 9;
            int row = 40;
            
            row = row * col;
            
            if (counter % col == 0) 
            {
                Console.WriteLine();
                if (counter % row  == 0)
                {
                    Console.ReadKey(); // Wait for some key. 
                    Console.Write("\r"); // Move marker to left.
                }
            }
        }
    }
}

/** Console output:
9995831 9995837 9995849 9995861 9995891 9995903 9995911 9995927 9995971
9995987 9995989 9996001 9996011 9996059 9996067 9996073 9996089 9996137
9996139 9996149 9996157 9996209 9996211 9996241 9996247 9996263 9996313
9996359 9996361 9996373 9996419 9996457 9996461 9996487 9996491 9996509
9996517 9996523 9996541 9996557 9996583 9996589 9996593 9996599 9996617
9996631 9996647 9996659 9996667 9996673 9996703 9996709 9996719 9996737
9996751 9996757 9996781 9996803 9996809 9996817 9996823 9996829 9996859
9996887 9996929 9996937 9996949 9996979 9996991 9997007 9997033 9997049
9997063 9997087 9997093 9997109 9997123 9997129 9997133 9997177 9997189
9997201 9997219 9997237 9997291 9997303 9997319 9997321 9997327 9997333
9997349 9997357 9997367 9997381 9997397 9997441 9997451 9997483 9997517
9997523 9997573 9997577 9997579 9997583 9997597 9997601 9997613 9997621
9997627 9997643 9997661 9997697 9997703 9997711 9997739 9997747 9997753
9997777 9997783 9997787 9997817 9997829 9997831 9997859 9997873 9997877
9997879 9997913 9997927 9997937 9997951 9997957 9997969 9997987 9997991
9997997 9998017 9998033 9998099 9998117 9998119 9998129 9998141 9998143
9998147 9998173 9998179 9998201 9998203 9998207 9998239 9998249 9998273
9998279 9998281 9998309 9998321 9998323 9998333 9998377 9998381 9998393
9998413 9998423 9998441 9998447 9998459 9998479 9998539 9998543 9998557
9998561 9998581 9998587 9998603 9998623 9998633 9998641 9998689 9998699
9998701 9998719 9998741 9998743 9998749 9998753 9998777 9998797 9998801
9998809 9998851 9998861 9998867 9998887 9998893 9998903 9998929 9998969
9998971 9998977 9999047 9999049 9999053 9999071 9999083 9999161 9999163
9999167 9999193 9999217 9999221 9999233 9999271 9999277 9999289 9999299
9999317 9999337 9999347 9999397 9999401 9999419 9999433 9999463 9999469
9999481 9999511 9999533 9999593 9999601 9999637 9999653 9999659 9999667
9999677 9999713 9999739 9999749 9999761 9999823 9999863 9999877 9999883
9999889 9999901 9999907 9999929 9999931 9999937 9999943 9999971 9999973
9999991Press any key to continue . . .
**/