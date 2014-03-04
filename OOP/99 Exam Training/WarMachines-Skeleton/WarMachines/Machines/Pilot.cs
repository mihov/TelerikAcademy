namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using WarMachines.Interfaces;

    public class Pilot : IPilot
    {
        private string name;
        private IList<IMachine> machineList;

        public Pilot(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Name cannot be empty.");
            }

            this.Name = name;
            this.machineList = new List<IMachine>();
        }

        public string Name
        {
            get 
            { 
                return this.name; 
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be empty.");
                }
                
                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            if (machine == null)
            {
                throw new ArgumentNullException("Machine cannot be null.");
            }
            
            this.machineList.Add(machine);
        }

        public string Report()
        {
            StringBuilder report = new StringBuilder();

            string numberOfMachines;
            string oneOrMoreMachimes = "machines";
            int machineCount = this.machineList.Count;

            if (machineCount > 0)
            {
                numberOfMachines = machineCount.ToString();

                if (machineCount == 1)
                {
                    oneOrMoreMachimes = "machine";
                }
            }
            else
            {
                numberOfMachines = "no";
            }

            report.AppendLine(string.Format("{0} - {1} {2}", this.Name, numberOfMachines, oneOrMoreMachimes));

            var sortedMachines = this.machineList.OrderBy(m => m.HealthPoints).ThenBy(m => m.Name);

            if (this.machineList.Count > 0)
            {
                foreach (var item in sortedMachines)
                {
                    report.Append(item.ToString());
                }
            }

            return report.ToString().TrimEnd();
        }
    }
}
