namespace CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    using Interface;
    using Enumeration;

    public class Manager : Employee, IManager
    {
        private IList<Employee> employers;

        public Manager(int id, string firstName, string lastName, decimal salary, Department department, IList<Employee> employers)
            : base(id, firstName, lastName, salary, department)
        {
            this.Employers = employers;
        }

        public IList<Employee> Employers
        {
            get
            {
                return this.employers;
            }

            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("List of employers canot be empty!");
                }
                this.employers = value;
            }
        }

        public override string ToString()
        {
            string str = String.Format("{0}: {1} ", this.GetType().Name, base.ToString());

            return str;
        }
    }
}
