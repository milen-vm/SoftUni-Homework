using System;
using System.Collections.Generic;

public class Student
{
    private string firstName;
    private string lastName;
    private int age;
    private int facultyNumber;
    private string phone;
    private string email;
    private IList<int> marks;
    private int groupNumber;

    public Student(string firstName, string lastName, int age, int facultyNumber, string phone, string email, IList<int> marks, int groupNumber)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.FacultyNumber = facultyNumber;
        this.Phone = phone;
        this.Email = email;
        this.Marks = marks;
        this.GroupNumber = groupNumber;
    }

    public string FirstName 
    {
        get 
        {
            return this.firstName;
        }

        set
        {
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
            this.lastName = value;
        }
    }

    public int Age
    {
        get
        {
            return this.age;
        }

        set
        {
            this.age = value;
        }
    }

    public int FacultyNumber
    {
        get
        {
            return this.facultyNumber;
        }

        set
        {
            this.facultyNumber = value;
        }
    }

    public string Phone
    {
        get
        {
            return this.phone;
        }

        set
        {
            this.phone = value;
        }
    }

    public string Email
    {
        get
        {
            return this.email;
        }

        set
        {
            this.email = value;
        }
    }

    public IList<int> Marks
    {
        get
        {
            return this.marks;
        }

        set
        {
            this.marks = value;
        }
    }

    public int GroupNumber
    {
        get
        {
            return this.groupNumber;
        }

        set
        {
            this.groupNumber = value;
        }
    }

    public bool IsWeak(IList<int> marks)
    {
        int counter = 0;
        foreach (var item in marks)
        {
            if (item == 2)
            {
                ++counter;
            }
        }

        if (counter >= 2)
        {
            return true;
        }

        return false;
    }

    public override string ToString()
    {
        string str = this.firstName;
        str += " " + this.lastName;
        str += "; Age: " + this.age;
        str += ";\nFaculty number: " + this.facultyNumber;
        str += "; Phone: " + this.phone;
        str += ";\nEmail: " + this.email;
        str += "; Marks: " + string.Join(", ", this.marks);
        str += "; Group number: " + this.groupNumber;
        str += ".\n";

        return str;
    }
}
