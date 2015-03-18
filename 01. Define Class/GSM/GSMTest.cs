namespace Phone
{
    using System;
    using System.Collections.Generic;
    public class GsmTest
    {
        public static List<Gsm> GeneratePhones()
        {
            // Array with all instaces of GSM
            List<Gsm> phones = new List<Gsm>();

            // Add phones to the array
            phones.Add(new Gsm
                ("Lumia 900", "Nokia", 700, "Pesho", new Battery(BatteryType.NiCd), new Display(3.5f, 2.4f, 320000000)));

            phones.Add(new Gsm
                ("Xperia", "Sony",250, "Ivan", new Battery(BatteryType.LiIon), new Display(3.1f, 2.1f, 1000000)));

            phones.Add(new Gsm
                ("Galaxy S6", "Samsung", 1050, "Gosho", new Battery(BatteryType.NiMH), new Display(4.1f, 3.1f, 64000000)));

            phones.Add(Gsm.IPhone);

            return phones;
        }
            
        
    }
}