namespace Human
{
    using System;

    class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentNullException("Grade can not be negative.");
                }

                this.grade = value;
            }
        }

        public override string ToString()
        {
            //return string.Format("Hello");

            return this.FirstName +"\t"+this.LastName+"\t"+ this.Grade;
            
        }
    }
}
