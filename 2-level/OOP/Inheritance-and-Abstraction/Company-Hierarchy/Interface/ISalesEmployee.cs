namespace CompanyHierarchy.Interface
{
    using System;
    using System.Collections.Generic;

    interface ISalesEmployee
    {
        IList<Sale> Sales { get; set; }
    }
}
