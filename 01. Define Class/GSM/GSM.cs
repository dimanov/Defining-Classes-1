/*
Problem 1. Define class
Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors).
Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
 */


namespace Phone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public class Gsm
    {
        // Static variables
        private static Gsm samsungNote3 = new Gsm("Note 3", "Samsung", 900, "Pesho", new Battery(BatteryType.NiMH), new Display(4.5f, 2.3f, 16000000));

        // Fields
        private string model;
        private string manufacturer;
        private int? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>();

        // Constructors
        public Gsm(string model , string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = null;
            this.Owner = null;
            this.Battery = null;
            this.Display = null;
        }

        public Gsm(string model, string manufacturer, int price , string owner , Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        // Properties
        public List<Call> CallHistory
        {
            get { return this.callHistory; }
        }

        public static Gsm IPhone
        {
            get { return samsungNote3; }
        }
        public string Model
        {
            get { return this.model; }
            set 
            {
                // Validation of string  --> it shouldn't be empty
                if (value != "" || value == null)
                {
                    this.model = value;
                } 
                else
                {
                    throw new Exception("String shouldn't be empty!");
                }
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                // Validation of string  --> it shouldn't be empty
                if (value != "" || value == null)
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new Exception("String shouldn't be empty!");
                }
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                // Validation of string  --> it shouldn't be empty
                if (value != "" || value == null)
                {
                    this.owner = value;
                }
                else
                {
                    throw new Exception("String shouldn't be empty!");
                }
            }
        }

        public int? Price
        {
            get { return this.price; }
            set 
            {
                // Validation of the price   -->  It shouldn't be zero or less
                if (value >= 0 || value == null)
                {
                    this.price = value;
                }
                else
                {
                    throw new Exception("Price can not be negative!");
                }
            }
        }

        public Battery Battery
        {
            get { return this.battery ;}
            set { this.battery = value;}
        }

        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }
        // Methods

        // Add call to the call history
        public void AddCall(Call call)
        {
            this.CallHistory.Add(call);
        }

        // Remove call from the call history
        public void RemoveCall(Call call)
        {
            this.CallHistory.Remove(call);
        }

        // Method for calculation of calls prices
        public double CallPrice(double pricePerMinute)
        {
            double price = 0;

            foreach (var call in this.CallHistory)
            {
                price += call.Duration * pricePerMinute;
            }

            return price;
        }

        // Remove all calls from call history
        public void DeleteCallHistory()
        {
                this.CallHistory.RemoveAll(x => x.Duration >= 0);
        }

        // Method for proper printing on the console
        public override string ToString()
        {
            // We use StringBuilder because it is faster than concatenating strings
            System.Text.StringBuilder result = new System.Text.StringBuilder();

            // If a field has a value of null , it wouldn't be added to the result
            if (this.Model != null)
            {
                result.Append("Model: ".PadRight(15, ' '));
                result.Append(this.Model);
                result.AppendLine();
            }
            if (this.Manufacturer != null)
            {
                result.Append("Manufacturer: ".PadRight(15, ' '));
                result.Append(this.Manufacturer);
                result.AppendLine();
            }
            if (this.Price != null)
            {
                result.Append("Price: ".PadRight(15, ' '));
                result.Append(this.Price);
                result.AppendLine();
            }
            if (this.Owner != null)
            {
                result.Append("Owner: ".PadRight(15, ' '));
                result.Append(this.Owner);
                result.AppendLine();
            }
            if (this.Battery != null)
            {
                result.Append("Battery: ".PadRight(15, ' '));
                result.Append(this.Battery.ToString());
                result.AppendLine();
            }
            if (this.Display != null)
            {
                result.Append("Display: ".PadRight(15, ' '));
                result.Append(this.Display.ToString());
                result.AppendLine();
            }

            string stringResult = result.ToString();
            return stringResult;
        }
    }
}
