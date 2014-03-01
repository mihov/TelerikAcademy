namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Discipline : People // наследявам People заради name & comments, в следващиет задачи ще ползвам Interface
    {
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
            : base(name)
        {
            this.numberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public Discipline(string name, int numberOfLectures, int numberOfExercises, string comments)
            : this(name, numberOfLectures, numberOfExercises)
        {
            this.Comments = comments;
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Number of lectures can not be negative.");
                }
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Number of exercises can not be negative.");
                }
                this.numberOfExercises = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} [L:{1}/E:{2}] <<{3}>>", this.Name, this.NumberOfLectures, this.NumberOfExercises, this.Comments);
        }
    }
}
