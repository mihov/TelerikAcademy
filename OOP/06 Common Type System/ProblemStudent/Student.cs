namespace ProblemStudent
{
    using System;
    using System.Linq;
    using System.Text;

    class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string permanentAddress;
        private string mobilePhone;
        private string email;
        public uint SSN { get; set; }
        public uint Course { get; set; }
        public Specialty? Specialty { get; set; }
        public University? University { get; set; }
        public Faculty? Faculty { get; set; }

        public Student(string fName, string mName, string lName, string address, string phone, string email,
                       uint ssn, uint course, Specialty? specialty, University? university, Faculty? faculty)
        {
            this.FistrName = fName;
            this.MiddleName = mName;
            this.LastName = lName;
            this.PermanentAddress = address;
            this.MobilePhone = phone;
            this.Email = email;
            this.SSN = ssn;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }

        public string FistrName
        {
            get { return this.firstName; }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name can not be null or empty.");
                }
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get { return this.middleName; }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Middle name can not be null or empty.");
                }
                this.middleName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name can not be null or empty.");
                }
                this.lastName = value;
            }
        }

        public string Email
        {
            get { return this.email; }

            set
            {
                if (!value.Contains('@'))
                {
                    throw new ArgumentException("Enter valid email.");
                }
                this.email = value;
            }
        }

        public string PermanentAddress
        {
            get { return this.permanentAddress; }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Address can not be null or empty.");
                }
                this.permanentAddress = value;
            }
        }

        public string MobilePhone
        {
            get { return this.mobilePhone; }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Mobile phone can not be null or empty.");
                }
                else if (value.Length < 4)
                {
                    throw new ArgumentNullException("Mobile phone must be minimum four digits.");
                }
                this.mobilePhone = value;
            }
        }

        public override bool Equals(object equalTo)
        {
            Student student = equalTo as Student;

            if (!Object.Equals(this.FistrName, student.FistrName)) return false;
            if (!Object.Equals(this.MiddleName, student.MiddleName)) return false;
            if (!Object.Equals(this.LastName, student.LastName)) return false;
            if (!Object.Equals(this.PermanentAddress, student.PermanentAddress)) return false;
            if (!Object.Equals(this.MobilePhone, student.MobilePhone)) return false;
            if (!Object.Equals(this.email, student.email)) return false;
            if (this.SSN != student.SSN) return false;
            if (this.Course != student.Course) return false;
            if (this.Specialty != student.Specialty) return false;
            if (this.University != student.University) return false;
            if (this.Faculty != student.Faculty) return false;
            return true;
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return student1.Equals(student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !student1.Equals(student2);
        }

        public override int GetHashCode()
        {
            return this.FistrName.GetHashCode() ^
                   this.MiddleName.GetHashCode() ^
                   this.LastName.GetHashCode() ^
                   this.PermanentAddress.GetHashCode() ^
                   this.MobilePhone.GetHashCode() ^
                   this.Email.GetHashCode() ^
                   this.SSN.GetHashCode() ^
                   this.Course.GetHashCode() ^
                   this.Specialty.GetHashCode() ^
                   this.University.GetHashCode() ^
                   this.Faculty.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(String.Format("SSN: {0}", this.SSN));
            result.AppendLine(String.Format("N: {0} {1} {2}", this.FistrName, this.MiddleName, this.LastName));
            result.AppendLine(String.Format("A: {0}", this.PermanentAddress));
            result.AppendLine(String.Format("P: {0}", this.MobilePhone));
            result.AppendLine(String.Format("@: {0}", this.Email));
            result.AppendLine(String.Format("C: {0}", this.Course));
            result.AppendLine(String.Format("S: {0}", this.Specialty));
            result.AppendLine(String.Format("U: {0}", this.University));
            result.AppendLine(String.Format("F: {0}", this.Faculty));

            return result.ToString();
        }


        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(Student otherStudent)
        {
            int result = this.FistrName.CompareTo(otherStudent.FistrName);
            
            if (result != 0)
            {
                return result;
            }
            else
            {
                return this.SSN.CompareTo(otherStudent.SSN);
            }
        }
    }
}
