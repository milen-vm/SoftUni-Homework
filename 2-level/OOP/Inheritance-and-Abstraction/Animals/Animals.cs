using System;
using System.Linq;

public enum Gender
{
    Male,
    Female
}

class Animals
{
    static void Main()
    {
        Dog dog = new Dog("Sharo", 3, Gender.Male);
        Console.WriteLine(dog);
        dog.ProduceSound();
        Console.WriteLine();

        Frog frog = new Frog("Boko", 1, Gender.Male);
        Console.WriteLine(frog);
        frog.ProduceSound();
        Console.WriteLine();

        Cat cat = new Cat("Misho", 4, Gender.Male);
        Console.WriteLine(cat);
        cat.ProduceSound();
        Console.WriteLine();

        Kitten kity = new Kitten("Mimi", 2);
        Console.WriteLine(kity);
        kity.ProduceSound();
        Console.WriteLine();

        Tomcat tomCat = new Tomcat("Tomi", 8);
        Console.WriteLine(tomCat);
        tomCat.ProduceSound();
        Console.WriteLine();

        Animal[] animals = new Animal[]
        {
            new Dog("Sharo", 3, Gender.Male),
            new Frog("Boko", 1, Gender.Male),
            new Cat("Misho", 4, Gender.Male),
            new Kitten("Mimi", 2),
            new Tomcat("Tomi", 8),
            new Dog("Bobi", 12, Gender.Male),
            new Cat("Juja", 4, Gender.Female),
            new Dog("Mima", 3, Gender.Female),
            new Frog("Poko", 3, Gender.Female),
            new Kitten("Pipi", 6)
        };

        var animalsBygroups = animals.GroupBy(GetAnimalKind,            // Down here I have copied from a colleague :)
            (g, a) => new { kind = g, averagAge = a.Average(animal => animal.Age) });

        foreach (var animalGroup in animalsBygroups)
        {
            Console.WriteLine("The average age of {0}s is {1:f2}.", animalGroup.kind, animalGroup.averagAge);
        }
    }

    public static string GetAnimalKind(Animal animal)
    {
        string kind = "";
        if (animal.GetType().BaseType.Name == "Animal")
        {
            kind = animal.GetType().Name;
        }
        else
        {
            kind = animal.GetType().BaseType.Name;
        }
        return kind;
    }
}