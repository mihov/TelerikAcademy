namespace MobileWorld
{
    using System;

    public enum BatteryType
    {
        Unknown, NiMH, NiCd, LiIon, LiPoly
    }
    
    class Battery
    {
        private string model;
        private uint? idleTime;
        private uint? talkTime;
        private BatteryType batteryType;

        public Battery(string model)
        {
            this.model = model;
            this.idleTime = null;
            this.talkTime = null;
            this.batteryType = BatteryType.Unknown;
        }

        public Battery(string model, uint? idleTime, uint? talkTime, BatteryType batteryType)
        {
            this.model = model;
            this.idleTime = idleTime;
            this.talkTime = talkTime;
            this.batteryType = batteryType;
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

        public uint? IdleTime
        {
            get { return this.idleTime; }

            set
            {
                if (value < 0)
                    throw new ArgumentException("Idle time can not be negative!");

                else
                    this.idleTime = value;
            }
        }

        public uint? TalkTime
        {
            get { return this.talkTime; }

            set
            {
                if (value < 0)
                    throw new ArgumentException("Talk time can not be negative!");

                else
                    this.talkTime = value;
            }
        }

        public BatteryType BattType 
        {
            get { return this.batteryType; }
            set { this.batteryType = value; } 
        }

    }
}
