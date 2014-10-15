namespace School.Organisation
{
    using System;

    public class Student : ObjectName
    {
        private int classNumber;

        public Student(string name, int classNumber, string details = null)
            : base(name, details)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber 
        {
            get 
            {
                return this.classNumber;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Class number cannot be zero or negative!");
                }

                this.classNumber = value;
            }
        }

        public override string ToString()
        {
            string str = "Student: " + base.ToString() + string.Format("Class number: {0}.", this.classNumber);

            return str;
        }
    }
}
