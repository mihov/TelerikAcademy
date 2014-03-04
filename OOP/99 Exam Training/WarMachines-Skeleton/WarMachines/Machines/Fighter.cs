namespace WarMachines.Machines
{
    using System;
    using System.Text;

    using WarMachines.Interfaces;

    public class Fighter : Machine, IFighter
    {
        private static double initialHealthPoints = 200;       

        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode)
            : base(name, attackPoints, defensePoints, initialHealthPoints)
        {
            this.StealthMode = stealthMode;
        }

        public bool StealthMode { get; private set; }

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(base.ToString());

            string stealthMode = (this.StealthMode) ? OnSign : OffSign;
            result.AppendLine(string.Format(" *Stealth: {0}", stealthMode));
            return result.ToString();
        }
    }
} 