namespace MobileWorld
{

    using System;
    using System.Text;
    
    class Call
    {
        private DateTime startCall;
        private DateTime endCall;
        private string dialeTo;

        public Call(DateTime startCall, DateTime endCall, string dialeTo)
        {
            this.startCall = startCall;
            this.endCall = endCall;
            this.dialeTo = dialeTo;
        }

        public int Duration
        {
            get { return (int)((this.endCall - this.startCall).TotalSeconds); }
        }

        public string DialeTo
        {
            get { return this.dialeTo; }
        }

        public string Date
        {
            get { return this.startCall.ToShortDateString(); }
        }

        public string Time
        {
            get { return this.startCall.ToShortTimeString(); }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("| Date: "); result.Append(this.Date);
            result.Append("\t| Duration: "); result.Append(this.Duration.ToString().PadRight(20));
            result.AppendLine("|");

            result.Append("| Time: "); result.Append(this.Time);
            result.Append("\t| Diale to: "); result.Append(this.DialeTo.PadRight(20));
            result.Append("|");

            return result.ToString();
        }
    }
}
