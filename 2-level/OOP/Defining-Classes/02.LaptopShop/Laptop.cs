using System;
using System.Text;

public class Laptop
{
    private string model;
    private decimal price;
    private string manufacturer;
    private string processor;
    private int ram;
    private string graphicsCard;
    private string hdd;
    private string screen;
    private Battery battery;   

    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("The value for model can not be empty!");
            }
            this.model = value;
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
                throw new ArgumentOutOfRangeException("The price can not be zero or negative!");
            }
            this.price = value;
        }
    }

    public string Manufacturer
    {
        get
        {
            return this.manufacturer;
        }
        set
        {
            if (value != null && string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("The value for manufacturer can not be empty!");
            }
            this.manufacturer = value;
        }
    }

    public string Processor
    {
        get
        {
            return this.processor;
        }
        set
        {
            if (value != null && string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("The value for processor can not be empty!");
            }
            this.processor = value;
        }
    }

    public int Ram
    {
        get
        {
            return this.ram;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid ram size!");
            }
            this.ram = value;
        }
    }

    public string GraphicsCard
    {
        get
        {
            return this.graphicsCard;
        }
        set
        {
            if (value != null && string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("The value for graphic card can not be empty!");
            }
            this.graphicsCard = value;
        }
    }

    public string Hdd
    {
        get
        {
            return this.hdd;
        }
        set
        {
            if (value != null && string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("The hdd can not be empty!");
            }
            this.hdd = value;
        }
    }

    public string Screen
    {
        get
        {
            return this.screen;
        }
        set
        {
            if (value != null && string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("The value for screen can not be empty!");
            }
            this.screen = value;
        }
    }

    public Laptop(string model, decimal price, string manufacturer = null, string processor = null, int ram = 0, string graphicsCard = null, string hdd = null, string screen = null, Battery batt = null)
    {
        this.Model = model;
        this.Price = price;
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.Ram = ram;
        this.GraphicsCard = graphicsCard;
        this.Hdd = hdd;
        this.Screen = screen;
        this.battery = batt;
    }

    public override string ToString()
    {
        StringBuilder laptopString = new StringBuilder();
        laptopString.Append("Laptop model: ").Append(this.model).Append(", ");

        if (manufacturer != null)
        {
            laptopString.Append("manufacturer: ").Append(this.manufacturer).Append(", ");
        }

        if (processor != null)
        {
            laptopString.Append("processor: ").Append(this.processor).Append(", ");
        }

        if (ram != 0)
        {
            laptopString.Append("ram: ").Append(this.ram).Append("GB, ");
        }

        if (graphicsCard != null)
        {
            laptopString.Append("graphics card: ").Append(this.graphicsCard).Append(", ");
        }

        if (hdd != null)
        {
            laptopString.Append("hdd: ").Append(this.hdd).Append(", ");
        }

        if (screen != null)
        {
            laptopString.Append("screen: ").Append(this.screen).Append(", ");
        }

        if (battery != null)
        {
            laptopString.Append("battery: ").Append(battery);
        }

        laptopString.Append("price: ").Append(this.price).Append("lv.");

        return laptopString.ToString();
    }
}