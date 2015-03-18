namespace Phone
{
    using System;
    using System.Collections.Generic;
    class CallHistoryTest
    {
        public static Gsm GenerateCallHistory()
        {
            Gsm gsm = new Gsm("Galaxy S3", "Samsung");
            gsm.AddCall(new Call(new DateTime(2015, 03, 09, 22, 03, 05), "+359 879 654321", 30));
            gsm.AddCall(new Call(new DateTime(2015, 03, 10, 15, 13, 17), "+359 899 123456", 12));
            gsm.AddCall(new Call(new DateTime(2015, 03, 10, 18, 03, 43), "+359 879 654321", 49));
            gsm.AddCall(new Call(new DateTime(2015, 03, 15, 11, 35, 25), "+359 856 754236", 154));
            gsm.AddCall(new Call(new DateTime(2015, 03, 16, 17, 03, 14), "+359 897 651241", 37));

            return gsm;
        }
    }
}