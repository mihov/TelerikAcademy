namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public class People
    {
        private string name;
        private string comments;

        public People(string name): this(name, null)
        {
            this.Name = name;
        }

        public People(string name, string comments)
        {
            this.Name = name;
            this.Comments = comments;
        }

        public string Comments
        {
            get 
            {
                return this.comments;
            }
            set
            {
                this.comments = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can not be empty!");
                }
                name = value;
            }
        }
    }
}
