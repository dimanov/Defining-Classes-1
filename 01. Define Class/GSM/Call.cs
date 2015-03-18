namespace Phone
{
    using System;
    public class Call
    {
        // Fields
        private DateTime date;
        private string dialledPhoneNumber;
        private int duration;

        // Constructors

        public Call(DateTime date , string dialledPhonenumber, int duration)
        {
            this.Date = date;
            this.DialledPhoneNumber = dialledPhonenumber;
            this.Duration = duration;
        }

        // Properties
        public DateTime Date
        {
            get {return this.date;}
            private set { this.date = value; }
        }
        public string DialledPhoneNumber 
        { 
            get { return this.dialledPhoneNumber; }
            private set { this.dialledPhoneNumber = value; } 
        }
        public int Duration 
        {
            get { return this.duration; }
            private set 
            {
                if (value >= 0)
                {
                    this.duration = value;
                }
                else
                {
                    throw new Exception("Duration of call can not be negative number");
                }
            }
        }

        public override string ToString()
        {
            var output = new System.Text.StringBuilder();

            output.Append(String.Format("On {0:dd.MM.yyyy  HH:mm:ss} had conversation with {1} for {2} seconds.", this.Date, this.DialledPhoneNumber, this.Duration));

            return output.ToString();
        }
    }
}