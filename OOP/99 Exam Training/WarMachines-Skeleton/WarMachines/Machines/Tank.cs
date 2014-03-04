namespace WarMachines.Machines
{
    using System;
    using System.Text;
    using WarMachines.Interfaces;

    public class Tank : Machine, ITank
    {
        private const double InitialHealthPoints = 100;
        private const int AttacModifier = 40;
        private const int DefenceModifer = 30;

        public Tank(string name, double attackPoints, double defensePoints)
            : base(name, attackPoints, defensePoints, InitialHealthPoints)
        {
            this.ToggleDefenseMode();
        }

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            this.DefenseMode = !this.DefenseMode;
            if (this.DefenseMode)
            {
                this.DefensePoints += DefenceModifer;
                this.AttackPoints -= AttacModifier;
            }
            else
            {
                this.DefensePoints -= DefenceModifer;
                this.AttackPoints += AttacModifier;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(base.ToString());

            string defenseMode = (this.DefenseMode) ? OnSign : OffSign;
            result.AppendLine(string.Format(" *Defense: {0}", defenseMode));

            return result.ToString();
        }
    }
}
