namespace Methods
{
    using System;

    public class Student
    {
        private const string NullOrEmptyFirstNameMSG = "First name cannot be null or empty!";
        private const string NullOrEmptyLastNameMSG = "Last name cannot be null or empty!";
        private const string NullOrEmptyDateOfBirthMSG = "Date of birth cannot be null or empty!";
        private const string FormatDateOfBirthMSG = "Date of birth format must be DD.MM.YYYY!";
        private const string NullOrEmptyOtherInfoMSG = "Other info cannot be null or empty!";

        private string firstName;
        private string lastName;
        private string otherInfo;
        private DateTime dateOfBirth;

        public Student(string firstName, string lastName, string dateOfBirth, string otherInfo)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.OtherInfo = otherInfo;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(NullOrEmptyFirstNameMSG);
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(NullOrEmptyLastNameMSG);
                }

                this.lastName = value;
            }
        }

        public string DateOfBirth
        {
            get
            {
                return this.dateOfBirth.ToString();
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(NullOrEmptyDateOfBirthMSG);
                }

                DateTime dateOfBirth;

                if (DateTime.TryParse(value, out dateOfBirth))
                {
                    this.dateOfBirth = dateOfBirth;
                }
                else
                {
                    throw new ArgumentException(FormatDateOfBirthMSG);
                }
            }
        }

        public string OtherInfo
        {
            get
            {
                return this.otherInfo;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(NullOrEmptyOtherInfoMSG);
                }

                this.otherInfo = value;
            }
        }

        public bool IsOlderThan(Student other)
        {
            var isOlderThanResult = this.dateOfBirth < other.dateOfBirth;
            return isOlderThanResult;
        }
    }
}
