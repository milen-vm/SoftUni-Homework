using System;

public class Student : Human
{
    private string facultyNumber;

    public Student(string firstName, string lastName, string facultyNumber)
        : base(firstName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    public string FacultyNumber
    {
        get
        {
            return this.facultyNumber;
        }

        set
        {
            if (value.Length < 5)
            {
                throw new ArgumentException("Faculty number must be at last 5 symblos!");
            }

            this.facultyNumber = value;
        }
    }

    public override string ToString()
    {
        string str = string.Format("Student: {0}, faculty number: {1}", base.ToString(), this.facultyNumber);

        return str;
    }
}
