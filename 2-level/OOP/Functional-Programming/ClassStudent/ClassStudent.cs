using System;
using System.Collections.Generic;
using System.Linq;

class ClassStudentsTest
{
    static void Main()
    {
        Student first = new Student("Ivan", "Ivanov", 22, 567813, "02 /-87-569-788", "ivan@abv.bg", new List<int>() { 5, 4, 6, 3 }, 2);
        Student second = new Student("Petar", "Petrov", 33, 548913, "02 78 157 335", "petar@google.com", new List<int>() { 5, 4, 2, 2 }, 1);
        Student third = new Student("Maria", "Filipova", 27, 795314, "+3592 /88-934-173", "maria@abv.bg", new List<int>() { 6, 6, 6, 5 }, 1);
        Student fourth = new Student("Ana", "Antonova", 18, 897513, "02-63-722-412", "ana@abv.bg", new List<int>() { 5, 4, 4, 3 }, 2);
        Student fifth = new Student("Ana", "Dimitrova", 25, 235414, "032-25-99-147", "dimo@mail.bg", new List<int>() { 4, 4, 5, 6 }, 2);

        List<Student> students = new List<Student>() { first, second, third, fourth, fifth };

        Console.WriteLine("----------Problem 4. Students by Group----------");
        var orderedsutdentsp4 = students.FindAll(st => st.GroupNumber == 2).OrderBy(st => st.FirstName);
        foreach (var student in orderedsutdentsp4)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine("----------Problem 5. Students by First and Last Name----------");
        var orderedSutdentsP5 = students.FindAll(st => string.Compare(st.FirstName, st.LastName, true) < 0);
        foreach (var student in orderedSutdentsP5)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine("----------Problem 6. Students by Age----------");
        var orderedSutdentsP6 = students.FindAll(st => st.Age >= 18 && st.Age <= 24).Select(st => new
            {
                FirstName = st.FirstName,
                LastName = st.LastName,
                Age = st.Age
            });
        foreach (var student in orderedSutdentsP6)
        {
            Console.WriteLine("{0} {1} Age: {2}", student.FirstName, student.LastName, student.Age);
        }
        Console.WriteLine();

        Console.WriteLine("----------Problem 7. Sort Students----------");
        var orderedSutdentsP7 = students.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName);
        foreach (var student in orderedSutdentsP7)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine("----------Problem 8. Filter Students by Email Domain----------");
        var orderedSutdentsP8 = students.FindAll(st => st.Email.EndsWith("@abv.bg"));
        foreach (var student in orderedSutdentsP8)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine("----------Problem 9. Filter Students by Phone----------");
        var orderedSutdentsP9 = students.FindAll(st => st.Phone.StartsWith("02 /") ||
            st.Phone.StartsWith("+3592 /") ||
            st.Phone.StartsWith("+359 2"));
        foreach (var student in orderedSutdentsP9)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine("----------Problem 10. Excellent Students----------");
        var orderedSutdentsP10 = students.FindAll(st => st.Marks.Contains(6)).Select(st => new
            {
                FullName = st.FirstName + " " + st.LastName,
                Marks = st.Marks
            });
        foreach (var student in orderedSutdentsP10)
        {
            Console.WriteLine("{0} Marks: {1}", student.FullName, string.Join(", ", student.Marks));
        }
        Console.WriteLine();

        Console.WriteLine("----------Problem 11. Weak Students----------");
        var orderedSutdentsP11 = students.FindAll(st => st.IsWeak(st.Marks));
        foreach (var student in orderedSutdentsP11)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine("----------Problem 12. Students Enrolled in 2014----------");
        var orderedSutdentsP12 = students.FindAll(st => st.FacultyNumber % 100 == 14);
        foreach (var student in orderedSutdentsP12)
        {
            Console.WriteLine(student);
        }
    }
}