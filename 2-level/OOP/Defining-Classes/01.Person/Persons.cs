using System;

public class Persons
{
    static void Main()
    {
        Person ivan = new Person("Ivan Ivanov", 100, "ivan@abv.bg");
        Console.WriteLine(ivan);

        Person petar = new Person("Petar Petrov", 79);
        Console.WriteLine(petar);
        
    }       
}
