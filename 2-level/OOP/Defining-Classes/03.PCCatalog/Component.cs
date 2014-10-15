using System;
using System.Text;

public class Component
{
    private string name;
    private decimal price;
    private string details;

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Invalid component name!");
            }

            this.name = value;
        }
    }

    public decimal Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("The price must be bigger than zero!");
            }

            this.price = value;
        }
    }

    public string Details
    {
        get
        {
            return this.details;
        }
        set
        {
            if (value != null && (value == "" || value == " "))
            {
                throw new ArgumentException("The details can not be empty!");
            }

            this.details = value;
        }
    }
    
    public Component(string name, decimal price, string details = null)
    {
        this.Name = name;
        this.Price = price;
        this.Details = details;
    }

    public override string ToString()
    {
        StringBuilder componentString = new StringBuilder();
        componentString.Append(this.name);

        if (this.details != null)
        {
            componentString.Append(": ").Append(this.details);
        }

        componentString.Append(", ").Append(this.price).Append("lv");

        return componentString.ToString();
    }
}
