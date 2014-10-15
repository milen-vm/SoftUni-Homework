namespace CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    using Enumeration;

    class CompanyHierarchy
    {
        static void Main()
        {
            List<Project> projects = new List<Project>
            {
                new Project("www.softuni.bg", new DateTime(2014, 1, 24), "SoftUni web site."),
                new Project("C# Basics", new DateTime(2014, 3, 8), "First basic course.", ProjectState.Closed)
            };

            List<Employee> employers = new List<Employee>
            {
                new Developer(33, "Vladisla", "Karamfilov", 1500m, Department.Production, projects),
                new Developer(34, "Petya", "Grozdarska", 1500m, Department.Production, projects)
            };
            List<Sale> sales = new List<Sale>
            {
                new Sale("Fast track PHP", new DateTime(2014, 6, 1), 480m),
                new Sale("Fast track Linux", new DateTime(2014, 10, 9), 50m)
            };

            List<Person> persons = new List<Person>
            {
                new Developer(33, "Vladisla", "Karamfilov", 1500m, Department.Production, projects),
                new Developer(34, "Petya", "Grozdarska", 1500m, Department.Production, projects),
                new Manager(12, "Svetlin", "Nakov", 4200m, Department.Production, employers),
                new SalesEmployee(10, "Aleksandra", "Aleksandrova", 1500, Department.Marketing, sales),
                new Customer(17, "Ivan", "Ivanov", 840m)
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person);
                Console.WriteLine();
            }
        }
    }
}
