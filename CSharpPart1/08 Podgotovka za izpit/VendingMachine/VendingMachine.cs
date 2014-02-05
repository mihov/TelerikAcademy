using System;

class VendingMachine
{
    static void Main()
    {
        int coin005 = int.Parse(Console.ReadLine());
        int coin010 = int.Parse(Console.ReadLine());
        int coin020 = int.Parse(Console.ReadLine());
        int coin050 = int.Parse(Console.ReadLine());
        int coin100 = int.Parse(Console.ReadLine());
        decimal amount = decimal.Parse(Console.ReadLine());
        decimal price = decimal.Parse(Console.ReadLine());

        decimal change = amount - price;

        if (change < 0)
        {
            Console.WriteLine("More {0:0.00}", -change);
        }
        else
        {
            decimal machineSum =
                0.05M * coin005 +
                0.10M * coin010 +
                0.20M * coin020 +
                0.50M * coin050 +
                1.00M * coin100;
            if (machineSum >= change)
            {
                Console.WriteLine("Yes {0:0.00}", machineSum - change);
            }
            else
            {
                Console.WriteLine("No {0:0.00}", change - machineSum);
            }
        }
    }
}