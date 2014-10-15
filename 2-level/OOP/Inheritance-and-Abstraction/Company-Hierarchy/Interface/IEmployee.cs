namespace CompanyHierarchy.Interface
{
    using System;
    using Enumeration;

    interface IEmployee
    {
        decimal Salary { get; set; }

        Department Department { get; set; }
    }
}