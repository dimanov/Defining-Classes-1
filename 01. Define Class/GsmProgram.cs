namespace Phone
{
    using System;
    using System.Collections.Generic;
    class MainProgram
    {
        public static void Main()
        {
            // GSM Test
            List<Gsm> phones = GsmTest.GeneratePhones();

            // Print information on the console for all instances of phones
            PrintSeparator("GSM Test");
            foreach (var phone in phones)
            {
                Console.WriteLine(phone.ToString());
            }

            // Call History test
            PrintSeparator("Call history test");

            Gsm gsm = CallHistoryTest.GenerateCallHistory();

            // Print on the console the call history
            PrintCallHistory(gsm);

            Console.WriteLine("Removing longest call from call history...");
            Console.WriteLine();

            // Remove longest call from call history
            Call longestCall = gsm.CallHistory[0];

            foreach (var call in gsm.CallHistory)
            {
                if (call.Duration > longestCall.Duration)
                {
                    longestCall = call;
                }
            }

            gsm.RemoveCall(longestCall);

            // Print on the console the call history
            PrintCallHistory(gsm);

            // Clear call history
            gsm.DeleteCallHistory();

            // Print after deleting call history
            PrintCallHistory(gsm);
        }

        public static void PrintCallHistory(Gsm gsm)
        {
            foreach (var call in gsm.CallHistory)
            {
                Console.WriteLine(call.ToString());
            }

            // Print total call price
            double price = gsm.CallPrice(0.37);
            if (price > 0)
            {
                Console.WriteLine("Total price of the calls: {0:C}", price);
            }
            else
            {
                Console.WriteLine("No call history");
            }
            Console.WriteLine();
        }

        public static void PrintSeparator(string text)
        {
            Console.WriteLine(new string('*', 30));
            Console.WriteLine(text);
            Console.WriteLine(new string('*', 30));
        }
        //Big thanks to DareDev1l for providing the code
    }
}