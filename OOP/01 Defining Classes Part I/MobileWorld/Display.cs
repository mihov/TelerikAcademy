namespace MobileWorld
{
    using System.Text;
    class Display
    {
        private byte? size;
        private uint? numberOfColors;

        public Display()
            : this(null, null)
        {

        }

        public Display(byte? size, uint? numberOfColors)
        {
            this.size = size;

            this.numberOfColors = numberOfColors;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(size);
            result.Append(" / ");
            result.Append(numberOfColors);
            return result.ToString();
        }

        public byte? Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public uint? NumberOfColors
        {
            get { return this.numberOfColors; }
            set { this.numberOfColors = value; }
        }
    }
}
