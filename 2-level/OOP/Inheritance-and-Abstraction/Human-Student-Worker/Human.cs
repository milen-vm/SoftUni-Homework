using System;

public abstract class Human
{
    private string firstName;
    private string lastName;

    public Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }

        set
        {
            if (value.Length < 2)
            {
                throw new ArgumentException("Invalid first name!");
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
            if (value.Length < 2)
            {
                throw new ArgumentException("Invalid last name!");
            }

            this.lastName = value;
        }
    }

    public override string ToString()
    {
        string str = string.Format("{0} {1}", this.firstName, this.lastName);

        return str;
    }
}
