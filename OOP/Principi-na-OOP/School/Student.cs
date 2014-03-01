namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public class Student : People
    {
        private string uniqueID;

        public Student(string name, string comments, string uniqueID)
            : base(name, comments)
        {
            this.UniqueID = uniqueID;
        }

        public string UniqueID
        {
            get
            {
                return this.uniqueID;
            }

            set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentException("Unique ID must be longer than 4 symbols.");
                }
                this.uniqueID = value;
            }
        }

        public override string ToString()
        {
            return "["+this.UniqueID +"] "+ this.Name + " <<"+ this.Comments+">>";
        }
    }
}
