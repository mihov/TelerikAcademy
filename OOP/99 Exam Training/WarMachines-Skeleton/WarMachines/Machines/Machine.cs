namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using WarMachines.Interfaces;

    public abstract class Machine : IMachine
    {
        protected const string OnSign = "ON";
        protected const string OffSign = "OFF";

        private string name;
        private IPilot pilot;
        private IList<string> targets;

        public Machine(string name, double attackPoints, double defensePoints, double healthPoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.HealthPoints = healthPoints;

            this.targets = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be empty.");
                }
                
                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Pilot cannot be null.");
                }
                
                this.pilot = value;
            }
        }

        public double HealthPoints { get; set; }

        public double AttackPoints { get; protected set; }

        public double DefensePoints { get; protected set; }

        public IList<string> Targets
        {
            get 
            { 
                return new List<string>(this.targets); 
            }
        }

        public void Attack(string target)
        {
            if (string.IsNullOrWhiteSpace(target))
            {
                throw new ArgumentNullException("Cannot add empty target");
            }
            
            this.targets.Add(target);
        }

        public override string ToString()
        {
            string targetsToText = string.Empty;

            if (this.Targets.Count > 0)
            {
                targetsToText = string.Join(", ", this.Targets);
            }
            else
            {
                targetsToText = "None";
            }

            StringBuilder report = new StringBuilder();

            report.AppendLine(string.Format("- {0}", this.Name));
            report.AppendLine(string.Format(" *Type: {0}", this.GetType().Name));
            report.AppendLine(string.Format(" *Health: {0}", this.HealthPoints));
            report.AppendLine(string.Format(" *Attack: {0}", this.AttackPoints));
            report.AppendLine(string.Format(" *Defense: {0}", this.DefensePoints));
            report.AppendLine(string.Format(" *Targets: {0}", targetsToText));

            return report.ToString();
        }
    }
}
