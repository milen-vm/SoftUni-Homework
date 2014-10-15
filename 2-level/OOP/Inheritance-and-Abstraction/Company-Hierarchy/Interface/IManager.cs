namespace CompanyHierarchy.Interface
{
    using System;
    using System.Collections.Generic;

    interface IManager
    {
        IList<Employee> Employers { get; set; }
    }
}
