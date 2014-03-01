namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Class
    {
        private List<Student> studentsSet;
        private List<Teacher> teachersSet;
        private string uniqueID;
        private string comments;

        public Class(string uniqueID)
            : this(uniqueID, null)
        {

        }

        public Class(string uniqueID, string comments)
        {
            this.UniqueID = uniqueID;
            this.Comments = comments;

            this.studentsSet = new List<Student>();
            this.teachersSet = new List<Teacher>();
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

        public string UniqueID
        {
            get
            {
                return this.uniqueID;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("ID must have value!");
                }
                this.uniqueID = value;
            }

        }

        public void AddStudent(Student student)
        {
            this.studentsSet.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teachersSet.Add(teacher);
        }

        public string ShowAllStudents()
        {
            if (this.studentsSet.Count > 0)
            {
                return string.Join("\n", this.studentsSet);
            }
            return "";
        }

        public string ShowAllTeachers()
        {
            if (this.teachersSet.Count > 0)
            {
                return string.Join("\n", this.teachersSet);
            }
            return "";
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Class: " + this.UniqueID);
            result.AppendLine("\n###   Teachers   ###");
            result.AppendLine(this.ShowAllTeachers());
            result.AppendLine("\n###   Students   ###");
            result.AppendLine(this.ShowAllStudents());
            return result.ToString();
        }

    }
}
