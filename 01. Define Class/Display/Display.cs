namespace Phone
{
    public class Display
    {
        // Fields
        private float sizeX;
        private float sizeY;
        private ulong numberOfColours;

        // Constructor
        public Display(float sizeX, float sizeY, ulong numberOfColours)
        {
            this.SizeX = sizeX;
            this.SizeY = sizeY;
            this.NumberOfColours = numberOfColours;
        }
    
        // Properties
        public float SizeX
        {
            get { return this.sizeX ; }
            set { this.sizeX = value ;}
        }

        public float SizeY
        {
            get { return this.sizeY; }
            set { this.sizeY = value; }
        }

        public ulong NumberOfColours
        {
            get { return this.numberOfColours; }
            set { this.numberOfColours = value; }
        }

        // Method override for proper printing on console
        public override string ToString()
        {
            var output = new System.Text.StringBuilder();

            output.Append(string.Format("Height: {0} , Width: {1}, Colors: {2}", this.SizeX, this.SizeY, this.NumberOfColours));

            return output.ToString();
        }
    }
}