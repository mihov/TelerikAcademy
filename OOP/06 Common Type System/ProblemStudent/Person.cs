namespace ProblemStudent
{
    using System;
    using System.Text;

    public class Person
    {
        private string name;
        public int? Age { get; set; }

        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }
        
        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name can not be empty.");
                }
                this.name = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(String.Format("Name: {0}", this.Name));
            result.AppendLine(String.Format("Age : {0}", (this.Age == null ? "Unknown" : this.Age.ToString())));

            return result.ToString();
        }


    }
}
