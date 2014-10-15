namespace School.Organisation
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Class : ObjectDetail
    {
        private string identifier;
        private List<Teacher> teachersList;
        private List<Student> studentsList;

        public Class(string identifier, List<Teacher> teachersList, List<Student> studentsList, string details = null)
            : base(details)
        {
            this.Identifier = identifier;
            this.teachersList = teachersList;
            this.studentsList = studentsList;
        }

        public string Identifier
        {
            get
            {
                return this.identifier;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Class identifier cannot be empty!");
                }

                this.identifier = value;
            }
        }

        public List<Teacher> TeachersList
        {
            get
            {
                return this.teachersList;
            }

            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("Teacher's list cannot be empty!");
                }

                this.teachersList = value;
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
            StringBuilder str = new StringBuilder("Class: ");
            str.Append(this.identifier + ", ");
            str.Append(base.ToString());
            str.Append("\nTeachers: ");

            foreach (var teacher in this.teachersList)
            {
                str.Append(teacher.Name + ", ");
            }

            str.Append("\nStudents: ");
            foreach (var student in this.studentsList)
            {
                str.Append(student.Name + ", ");
            }

            return str.ToString().TrimEnd(',', ' ');
        }
    }
}
