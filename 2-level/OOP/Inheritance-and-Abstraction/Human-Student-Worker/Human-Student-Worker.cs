using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>()
        {
            new Student("Ivan", "Ivanov", "A4789"),
            new Student("Petar", "Petrov", "A2397"),
            new Student("Georgi", "Todorov", "A3571"),
            new Student("Ana", "Dimitrova", "A4786"),
            new Student("Petar", "Tabakov", "A1452"),
            new Student("Tihomira", "Dobreva", "A3654"),
            new Student("Iordan", "Todorov", "A7854"),
            new Student("Maria", "Petrova", "A4413"),
            new Student("Biser", "Aleksandrov", "A9347"),
            new Student("Dimitar", "Dimitrov", "A4152"),
        };
        var sortedStudents = students.OrderBy(st => st.FacultyNumber);
        foreach (var student in sortedStudents)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine();

        List<Worker> workers = new List<Worker>()
        {
            new Worker("Vencislav", "Vasilev", 150m, 8),
            new Worker("Ianko", "Todorov", 180m, 8),
            new Worker("Grigor", "Toshev", 120m, 8),
            new Worker("Ivan", "Vasilev", 150m, 8),
            new Worker("Nikolay", "Nkolov", 220m, 8),
            new Worker("Jeliazko", "Jeliazkov", 140m, 8),
            new Worker("Georgi", "Batkof", 250m, 8),
            new Worker("Gonzo", "Vielicata", 380m, 8),
            new Worker("Nedialko", "Nedev", 150m, 8),
            new Worker("Ilia", "Iliev", 150m, 8),
        };
        var sortedWorkers = workers.OrderByDescending(w => w.MoneyPerHour);
        foreach (var worker in sortedWorkers)
        {
            Console.WriteLine(worker);
        }

        Console.WriteLine();

        List<Human> humans = new List<Human>();
        humans.AddRange(students);
        humans.AddRange(workers);

        var sortedHumans = humans
            .OrderBy(h => h.FirstName)
            .ThenBy(h => h.LastName);

        foreach (var human in sortedHumans)
        {
            Console.WriteLine(human.FirstName + " " + human.LastName + " " + human.GetType());
        }
    }
}
