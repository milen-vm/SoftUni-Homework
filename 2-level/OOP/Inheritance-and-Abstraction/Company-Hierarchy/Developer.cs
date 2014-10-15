namespace CompanyHierarchy
{
    using System;
    using Interface;
    using Enumeration;
    using System.Collections.Generic;

    class Developer : Employee, IDeveloper
    {
        private IList<Project> projects;

        public Developer(int id, string firstName, string lastName, decimal salary, Department department, IList<Project> projects)
            : base(id, firstName, lastName, salary, department)
        {
            this.Projects = projects;
        }

        public IList<Project> Projects
        {
            get
            {
                return this.projects;
            }

            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("List of projects cannot be empty");
                }

                this.projects = value;
            }
        }

        public override string ToString()
        {
            string str = String.Format("{0}: {1} ", this.GetType().Name, base.ToString());

            return str;
        }
    }
}
