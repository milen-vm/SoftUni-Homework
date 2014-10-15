using System;

public class Person
{
    private string name;
    private int age;
    private string email;

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
            if (string.IsNullOrEmpty(this.name))
            {
                throw new ArgumentNullException("Invalid name.");
            }
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
            if ((this.age < 1) || (this.age > 100))
            {
                throw new ArgumentOutOfRangeException("Invalid age. Valid age is in range [1...100].");
            }
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
            if (this.email != null && !this.email.Contains("@"))
            {
                throw new ArgumentException("Invalid email.");
            }
        }
    }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public Person(string name, int age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public override string ToString()
    {
        if (this.email == null)
        {
            return string.Format("Person {0}. Age {1}.", this.name, this.age);
        }
        else
        {
            return string.Format("Person {0}. Age {1}. Email {2}.", this.name, this.age, this.email);
        }
    }
}