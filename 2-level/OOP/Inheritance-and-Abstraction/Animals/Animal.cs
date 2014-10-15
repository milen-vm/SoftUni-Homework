using System;

public abstract class Animal : ISound
{
    private string name;
    private double age;
    private Gender gender;

    public Animal(string name, double age, Gender gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    public string Name
    {
        get
        {
            return this.name;
        }

        set
        {
            if (string.IsNullOrEmpty(value) || value.Length < 2)
            {
                throw new ArgumentException("Invalid name!");
            }

            this.name = value;
        }
    }

    public double Age
    {
        get 
        {
            return this.age;
        }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age must be bigger than zero!");
            }

            this.age = value;
        }
    }

    public Gender Gender
    {
        get
        {
            return this.gender;
        }

        set
        {
            this.gender = value;
        }
    }

    public override string ToString()
    {
        string str = string.Format("{0}, {1} years old, {2}.", this.name, this.age, this.gender);

        return str;
    }

    public abstract void ProduceSound();
}