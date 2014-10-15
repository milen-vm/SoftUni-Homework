namespace CompanyHierarchy
{
    using System;
    using Interface;
    using Enumeration;

    public class Employee : Person, IEmployee
    {
        private decimal salary;
        private Department department;

        public Employee(int id, string firstName, string lastName, decimal salary, Department department)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }

            set
            {
                Validation.ValidateAmount("Salary", value);
                this.salary = value;
            }
        }

        public Department Department
        {
            get
            {
                return this.department;
            }
            set
            {
                this.department = value;
            }
        }

        public override string ToString()
        {
            string str = String.Format("{0}, Salary: {1}, Department: {2}",
            base.ToString(), this.Salary, this.Department);

            return str;
        }
    }
}
