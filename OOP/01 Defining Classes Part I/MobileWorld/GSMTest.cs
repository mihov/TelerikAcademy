namespace MobileWorld
{
    using System;
    using System.Collections.Generic;

    class GSMTest
    {
        private const int lines = 57;
        public static void RunStart()
        {
            Console.WriteLine(new string('#', lines));
            Console.WriteLine("###########           GSM Test START          ###########");
            Console.WriteLine(new string('#', lines));
        }

        public static void RunEnd()
        {
            Console.WriteLine(new string('#', lines));
            Console.WriteLine("###########           GSM Test   END          ###########");
            Console.WriteLine(new string('#', lines));
        }

        public static void Run()
        {
            // Add header
            RunStart();

            // Create an array of few instances of the GSM class
            List<GSM> GSMList = new List<GSM>();

            GSMList.Add(new GSM("Galaxy S4", "Samsung", 500, "Ivan Ivanov", new Battery("SGS4", 700, 100, BatteryType.LiPoly), new Display(5, 10000000)));
            GSMList.Add(new GSM("Nexus 4", "Google", 300, "Georgi Georgiev", new Battery("NGoo4", 500, 70, BatteryType.LiIon), new Display(4, 5000000)));
            GSMList.Add(new GSM("HTC One", "HTC", 600, "Petar Petrov", new Battery("H-One33", 800, 200, BatteryType.NiCd), new Display(5, 320000000)));

            // Display the information about the GSMs in the array
            Console.WriteLine("Information about the GSMs in the array.");
            Console.WriteLine(new string('-', lines));
            
            foreach (var currentGSM in GSMList)
            {
                Console.WriteLine(currentGSM);
                Console.WriteLine(new string('-', lines));
            }

            // Display the information about the static property IPhone4S
            Console.WriteLine("\nInformation about the iPhone 4S.");
            Console.WriteLine(new string('-', lines));
            Console.WriteLine(GSM.IPhone4S);
            Console.WriteLine(new string('-', lines));

            // Add footer
            RunEnd();
        }
    }
}
