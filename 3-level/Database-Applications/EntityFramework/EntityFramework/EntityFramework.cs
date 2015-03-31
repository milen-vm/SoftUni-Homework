namespace EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EntityFramework
    {
        public static void Main()
        {
            // Problem 2.	Employee DAO Class
            AccessEmployee.GetFirstAndLastName();
            AccessEmployee.Create("Ivan", "Ivanov", "Developer", "Production", DateTime.Now, 25000);
            AccessEmployee.ChangeSalary(293, 50000m);
            AccessEmployee.DeleteEmployee(293);     // check if there is such a EmployeeId in your database

            // Problem 3.	Employees with Projects in 2002
            PrintEmployeesWithProjectsStartedInYear(2002);
            Console.WriteLine();

            // Problem 4.	Native SQL Query
            GetEmployeeWithProjectsAfterYearNativeSql(2002);
            Console.WriteLine();

            // Problem 5.	Employees by Department and Manager
            PrintEmployeesByDepartmentAndManager("Production", "Jo", "Brown");
            Console.WriteLine();

            // Problem 6.	Concurrent Database Changes with EF
            var softUniDbFirst = new SoftUniEntities();
            var softUniDbSecond = new SoftUniEntities();

            var departmentFirst = softUniDbFirst.Departments
                .FirstOrDefault(d => d.DepartmentID == 1);
            var departmentSecond = softUniDbSecond.Departments
                .FirstOrDefault(d => d.DepartmentID == 1);

            departmentFirst.Name = "Developing";
            departmentSecond.Name = "Coding";

            softUniDbFirst.SaveChanges();
            softUniDbSecond.SaveChanges();
            Console.WriteLine();

            // Problem 8.	Insert a New Project
            CreateNewProject("Front-End", new int[]{1, 6, 8});
            Console.WriteLine();

            // Problem 9.	Call a Stored Procedure
            GetAllProjectsForEmployee("Roberto", "Tamburello");
            Console.WriteLine();

        }

        private static void PrintEmployeesWithProjectsStartedInYear(int year)
        {
            var softUniDb = new SoftUniEntities();
            var employees = softUniDb.Employees
                .Where(e => e.Projects.Any(p => p.StartDate.Year == year))
                .Select(e => new
                {
                    Id = e.EmployeeID,
                    FirstName = e.FirstName,
                    LastName = e.LastName
                })
                .ToList();

            Console.WriteLine(string.Format("Employees with projects started in {0} year", year));
            if (employees.Any())
            {
                foreach (var emp in employees)
                {
                    Console.WriteLine(string.Format("{0} {1} {2}", emp.Id, emp.FirstName, emp.LastName));
                }
            }
            else
            {
                Console.WriteLine("No Employees");
            }

        }

        private static void GetEmployeeWithProjectsAfterYearNativeSql(int year)
        {
            var softUniDb = new SoftUniEntities();
            string query = "SELECT e.FirstName + ' ' + e.LastName " +
                           "FROM Employees e " +
                           "JOIN EmployeesProjects ep ON e.EmployeeID = ep.EmployeeID " +
                           "JOIN Projects p ON ep.ProjectID = p.ProjectID " +
                           "WHERE YEAR(p.StartDate) = {0}";
            var employees = softUniDb.Database.SqlQuery<string>(string.Format(query, year))
                .ToList();

            Console.WriteLine("Native Sql.");
            Console.WriteLine(string.Format("Employees with projects started in {0} year", year));
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

        }

        private static void PrintEmployeesByDepartmentAndManager(string departmentName, string managerFirstName, string managerLastName)
        {
            var softUniDb = new SoftUniEntities();
            var managerName = managerFirstName.Trim() + managerLastName.Trim();
            bool hasDepartment = softUniDb.Departments
                .Any(d => d.Name == departmentName);
            bool hasManager = softUniDb.Employees
                .Any(e => (e.FirstName + e.LastName == managerName));

            if (hasDepartment)
            {
                if (hasManager)
                {
                    var employees = softUniDb.Employees
                        .Where(e => (e.Department.Name == departmentName) &&
                                    (e.Employee1.FirstName + e.Employee1.LastName == managerName))
                        .Select(e => new
                        {
                            e.FirstName,
                            e.LastName
                        })
                        .ToList();

                    Console.WriteLine(string.Format("Employees from department: {0} and manager: {1} {2}.",
                        departmentName, managerFirstName, managerLastName));
                    if (employees.Any())
                    {
                        var num = 0;
                        foreach (var emp in employees)
                        {
                            ++num;
                            Console.WriteLine(string.Format("{0}. {1} {2}", num, emp.FirstName, emp.LastName));
                        }
                    }
                    else
                    {
                        Console.WriteLine("No employees.");
                    }
                    
                }
                else
                {
                    throw new ArgumentException("Invalid manager name.");
                }
            }
            else
            {
                throw new ArgumentException("Invalid department name.");
            }
        }

        private static void CreateNewProject(string projectName, int[] employeesIds)
        {
            var softUniDb = new SoftUniEntities();
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < employeesIds.Length; i++)
            {
                var employeeId = employeesIds[i];
                var employee = softUniDb.Employees.FirstOrDefault(e => e.EmployeeID == employeeId);
                if (employee != null)
                {
                    employees.Add(employee);
                }
            }

            var newProject = new Project()
            {
                Description = "Some important project",
                Employees = employees,
                EndDate = new DateTime(2015, 6, 18),
                Name = projectName,
                StartDate = new DateTime(2015, 3, 10)
            };

            softUniDb.Projects.Add(newProject);
            softUniDb.SaveChanges();
        }

        private static void GetAllProjectsForEmployee(string firstName, string lastName)
        {
            var softUniDb = new SoftUniEntities();
            var projects = softUniDb.usp_GetAllProjectsForEmployee(firstName, lastName).ToList();

            Console.WriteLine(string.Format("{0} {1} project`s:", firstName, lastName));
            foreach (var project in projects)
            {
                Console.WriteLine(project);
            }
        }
    }
}
