namespace MobileWorld
{
    using System;

    class GSMCallHistoryTest
    {
        private const int lines = 57;

        private static void RunStart()
        {
            Line('#');
            Console.WriteLine("###########     GSM Call History Test START   ###########");
            Line('#');
        }

        private static void RunEnd()
        {
            Line('#');
            Console.WriteLine("###########     GSM Call History Test   END   ###########");
            Line('#');
        }

        private static void Line(char lineChar)
        {
            Console.WriteLine(new string(lineChar, lines));
        }

        public static void Run()
        {
            // Add header
            RunStart();

            // Create an instance of the GSM class.
            GSM myNewPhone = new GSM("Galaxy S4", "Samsung", 500, "Ivan Ivanov", new Battery("SGS4", 700, 100, BatteryType.LiPoly), new Display(5, 10000000));
            Console.WriteLine("Current phone information.");
            Console.WriteLine(myNewPhone);
            Line('-');

            // Add few calls
            DateTime startCall = new DateTime(2014, 1, 4, 20, 30, 0, 0);
            DateTime endCall = new DateTime(2014, 1, 4, 20, 30, 45, 0);
            string callTo = "+359888777666";
            myNewPhone.AddCall(startCall, endCall, callTo);

            startCall = new DateTime(2014, 1, 4, 20, 40, 0, 0);
            endCall = new DateTime(2014, 1, 4, 20, 41, 10, 0);
            callTo = "+359888999000";
            myNewPhone.AddCall(startCall, endCall, callTo);

            startCall = new DateTime(2014, 1, 4, 21, 30, 0, 0);
            endCall = new DateTime(2014, 1, 4, 21, 30, 10, 0);
            callTo = "+359888123321";
            myNewPhone.AddCall(startCall, endCall, callTo);

            startCall = new DateTime(2014, 1, 4, 21, 43, 0, 0);
            endCall = new DateTime(2014, 1, 4, 21, 43, 50, 0);
            callTo = "+359999888777";
            myNewPhone.AddCall(startCall, endCall, callTo);

            // Display the information about the calls.
            Console.WriteLine("Information about the calls.");
            Line('-');
            foreach (var currentCall in myNewPhone.CallHistory)
            {
                Console.WriteLine(currentCall.ToString());
                Line('-');
            }

            // Assuming that the price per minute is 0.37 calculate
            // and print the total price of the calls in the history.
            Console.WriteLine("\n\n");
            Line('-');
            Console.WriteLine("Total price of the calls in the history is {0:F2}.", myNewPhone.TotalPrice(0.37M));

            // Remove the longest call from the history

            Line('-');
            myNewPhone.DelMaxCall();
            Console.WriteLine("The longest call in the history removed!");

            // and calculate the total price again.
            Line('-');
            Console.WriteLine("Total price of the calls in the history is {0:F2}.", myNewPhone.TotalPrice(0.37M));

            // Finally clear the call history 
            Line('-');
            myNewPhone.ClearCallHistory();
            Console.WriteLine("Call history clear!");

            // and print it
            Console.WriteLine("Information about the calls.");
            Line('-');

            foreach (var currentCall in myNewPhone.CallHistory)
            {
                Console.WriteLine(currentCall.ToString());
                Line('-');
            }

            // Add footer
            RunEnd();
        }
    }
}
