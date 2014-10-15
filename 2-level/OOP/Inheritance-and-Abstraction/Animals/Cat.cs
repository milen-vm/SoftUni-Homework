using System;

class Cat : Animal
{
    public Cat(string name, int age, Gender gender)
        : base(name, age, gender)
    {
    }

    public override void ProduceSound()
    {
        Console.WriteLine("{0} said: Miau - Miau!", this.Name);
    }
}
