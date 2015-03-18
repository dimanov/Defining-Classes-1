namespace Phone
{
    public class Battery
    {
        // Fields
        private BatteryType batteryModel;
        private int? hoursIdle;
        private int? hoursTalk;

        // Constructors
        public Battery(BatteryType batteryModel)
        {
            this.BatteryModel = batteryModel;
            this.HoursIdle = null;
            this.HoursTalk = null;
        }
        public Battery(BatteryType batteryModel , int hoursIdle, int hoursTalk)
        {
            this.BatteryModel = batteryModel;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;

        }

        // Properties
        public BatteryType BatteryModel 
        { 
            get { return this.batteryModel ; }
            set { this.batteryModel = value; } 
        }
        public int? HoursIdle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }

        public int? HoursTalk
        {
            get { return this.hoursTalk ; }
            set { this.hoursTalk = value; }
        }

        // Print appropriate with ToString
        public override string ToString()
        {
            System.Text.StringBuilder output = new System.Text.StringBuilder();

            // Battery model is always valid because constructor takes at least one argument
            output.Append(this.BatteryModel);
            output.Append("  ");

            if (this.HoursIdle != null)
            {
                output.Append(this.HoursIdle);
                output.Append(" hours idle , ");
            }
            if (this.HoursTalk != null)
            {
                output.Append(this.HoursIdle);
                output.Append(" hours talk.");
            }


            string result = output.ToString();

            return result;
        }
    }
}