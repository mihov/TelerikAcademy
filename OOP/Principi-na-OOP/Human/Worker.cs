namespace Human
{
    using System;

    class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;
        private int workDaysPerWeek = 5;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay, int workDaysPerWeek)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
            this.WorkDaysPerWeek = workDaysPerWeek;
        }

        public int WorkDaysPerWeek
        {
            get
            {
                return this.workDaysPerWeek;
            }

            set
            {
                if (value < 0 || value > 7)
                {
                    throw new ArgumentException("Week has only seven days.");
                }
                this.workDaysPerWeek = value;
            }
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Week salary can not be negative.");
                }

                this.weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Work Hours Per Day can not be negative.");
                }

                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return this.weekSalary / this.workDaysPerWeek * this.workHoursPerDay;
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2:0.00}",this.FirstName,  this.LastName, this.MoneyPerHour() );
        }
    }
}
