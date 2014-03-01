namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public class Teacher : People
    {
        private List<Discipline> disciplines;

        public Teacher(string name)
            : base(name)
        {
            this.disciplines = new List<Discipline>();
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.disciplines.Add(discipline);
        }

        public string ShowAllDisciplines()
        {
            if (this.disciplines.Count > 0)
            {
                return string.Join("\n", this.disciplines);
            }
            return string.Empty;

        }

        public override string ToString()
        {
            return string.Format("{0} <<{1}>>\n{2}", this.Name, this.Comments, this.ShowAllDisciplines());
        }
    }
}
