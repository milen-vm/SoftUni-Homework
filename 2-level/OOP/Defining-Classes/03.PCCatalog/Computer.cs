using System;
using System.Collections.Generic;

public class Computer
{
    private List<Component> components = new List<Component>();
    private decimal price;

    public decimal Price
    {
        get
        {
           return this.price;
        }
    }

    public Computer(List<Component> components)
    {
        this.components = components;

        foreach (Component component in this.components)
        {
            this.price += component.Price;
        }
    }

    public void PrintComputerComponents()
    {
        foreach (Component component in this.components)
        {
            Console.WriteLine(component);
        }

        Console.WriteLine("Total price: {0}lv", this.price);
        Console.WriteLine();
    }
}
