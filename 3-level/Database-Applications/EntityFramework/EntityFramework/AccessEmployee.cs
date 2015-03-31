namespace EntityFramework
{
    using System;
    using System.Linq;

    public static class AccessEmployee
    {
        public static void GetFirstAndLastName()
        {
            var softUniDb = new SoftUniEntities();
            var employees = softUniDb.Employees
                .Select(c => c.FirstName + " " + c.LastName)
                .ToList();
            
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }

        public static void Create(string firstName, string lastName, string jobTitle, string departmentName, DateTime hireDate,
            decimal salary)
        {
            var softUniDb = new SoftUniEntities();
            var departmentId = softUniDb.Departments
                .Where(d => d.Name == departmentName)
                .Select(d => d.DepartmentID)
                .FirstOrDefault();

            var newEmployee = new Employee
            {
                FirstName = firstName,
                LastName = lastName,
                JobTitle = jobTitle,
                DepartmentID = departmentId,
                HireDate = hireDate,
                Salary = salary
            };

            softUniDb.Employees.Add(newEmployee);
            softUniDb.SaveChanges();
        }

        public static void ChangeSalary(int employeeId, decimal newSalary)
        {
            var softUniDb = new SoftUniEntities();
            var employee = GetEmployeeById(employeeId, softUniDb);
            employee.Salary = newSalary;
            softUniDb.SaveChanges();

        }

        public static void DeleteEmployee(int employeeId)
        {
            var softUniDb = new SoftUniEntities();
            var employee = GetEmployeeById(employeeId, softUniDb);
            softUniDb.Employees.Remove(employee);
            softUniDb.SaveChanges();
        }

        private static Employee GetEmployeeById(int id, SoftUniEntities softUniDb)
        {
            var employee = softUniDb.Employees
                .FirstOrDefault(e => e.EmployeeID == id);

            return employee;
        }
    }
}
