namespace CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    using Interface;
    using Enumeration;

    public class SalesEmployee : Employee, ISalesEmployee
    {
        private IList<Sale> sales;

        public SalesEmployee(int id, string firstName, string lastName,
            decimal salary, Department department, IList<Sale> sales)
            : base(id, firstName, lastName, salary, department)
        {
            this.Sales = sales;
        }

        public IList<Sale> Sales
        {
            get
            {
                return this.sales;
            }

            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("Sales list cannot be empty!");
                }

                this.sales = value;
            }
        }

        public override string ToString()
        {
 
            string str = String.Format("{0}: {1} ", this.GetType().Name, base.ToString());

            return str;
        }
    }
}
