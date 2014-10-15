namespace CompanyHierarchy.Interface
{
    using System;
    using System.Collections.Generic;

    interface IDeveloper
    {
        IList<Project> Projects { get; set; }
    }
}
