

namespace School.Organisation
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Teacher : ObjectName
    {
        private List<Discipline> disciplinesList;

        public Teacher(string name, List<Discipline> disciplinesList, string details = null)
            : base(name, details)
        {
            this.DisciplinesList = disciplinesList;
        }

        public List<Discipline> DisciplinesList
        {
            get
            {
                return this.disciplinesList;
            }

            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("Discipline's list cannot be empty!");
                }

                this.disciplinesList = value;
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder("Teacher: ");
            str.Append(base.ToString());
            str.Append("\nDisciplines: ");

            foreach (var discipline in this.disciplinesList)
            {
                str.Append(discipline.Name + ", ");
            }

            return str.ToString().TrimEnd(',', ' ');
        }
    }
}
