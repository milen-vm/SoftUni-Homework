namespace School.Organisation
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Discipline : ObjectName
    {
        private int numberOfLectures;
        private List<Student> studentsList;

        public Discipline(string name, int numberOfLectures, List<Student> studentsList, string details = null)
            : base(name, details)
        {
            this.NumberOfLectures = numberOfLectures;
            this.StudentsList = studentsList;
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Number of lectures cannot be zero or negative!");
                }

                this.numberOfLectures = value;
            }
        }

        public List<Student> StudentsList
        {
            get
            {
                return this.studentsList;
            }

            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("Student's list cannot be empty!");
                }

                this.studentsList = value;
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder("Discipline: ");
            str.Append(base.ToString());
            str.Append(string.Format("Numbers of lectures {0},\nStudents: ", this.numberOfLectures));

            foreach (var student in this.studentsList)
            {
                str.Append(student.Name + ", ");
            }

            return str.ToString().TrimEnd(',', ' ');
        }
    }
}
