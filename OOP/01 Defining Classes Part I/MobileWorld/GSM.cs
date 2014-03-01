namespace MobileWorld
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class GSM
    {
        // GSM Fields
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory;

        private static GSM iPhone4S = new GSM("IPhone 4S", "Apple", 700, "Vasil Vasilev", new Battery("IP4S", 1000, 300, BatteryType.LiPoly), new Display(5, 32000000));

        public GSM(string model, string manufacturer)
            : this(model, manufacturer, null, null, null, null)
        {

        }

        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
            this.callHistory = new List<Call>();
        }

        public string Model
        {
            get { return this.model; }

            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Model, can not be null!");

                else
                    this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }

            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Model, can not be null!");

                else
                    this.manufacturer = value;
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Owner name can not be empty!");
                }
                else this.owner = value;
            }
        }

        public decimal? Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price can not be negative!");
                }
                else this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Model:\t\t\t"); result.AppendLine(this.Model);
            result.Append("Manufacturer:\t\t"); result.AppendLine(this.Manufacturer);

            result.AppendLine("Display");
            result.Append("\tSize:\t\t"); result.AppendLine(this.Display.Size.ToString());
            result.Append("\tColors:\t\t"); result.AppendLine(this.Display.NumberOfColors.ToString());

            result.AppendLine("Battery");
            result.Append("\tModel:\t\t"); result.AppendLine(this.Battery.Model);
            result.Append("\tType:\t\t"); result.AppendLine(this.Battery.BattType.ToString());

            result.Append("Owner:\t\t\t"); result.AppendLine(this.Owner);
            result.Append("Price:\t\t\t"); result.Append(this.Price.ToString());

            return result.ToString();
        }

        public static GSM IPhone4S
        {
            get { return iPhone4S; }
        }

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
            set { this.callHistory = value; }
        }

        public void AddCall(DateTime startCall, DateTime endCall, string callTo)
        {
            this.callHistory.Add(new Call(startCall, endCall, callTo));
        }

        public void DelCall(int callIndex)
        {
            if (this.callHistory.Count > callIndex && callIndex >= 0)
            {
                this.callHistory.RemoveAt(callIndex);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Invalid call index!");
            }

        }

        public void DelMaxCall()
        {
            int maxCallDuration = this.callHistory.Max(t => t.Duration);
            int callIndex = this.callHistory.FindIndex(t => t.Duration == maxCallDuration);
            this.DelCall(callIndex);
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public decimal TotalPrice(decimal pricePerMinute)
        {
            decimal result = 0;

            foreach (var currentCall in this.CallHistory)
            {
                result += currentCall.Duration;
            }

            result = result / 60 * pricePerMinute;

            return result;
        }
    }

}
