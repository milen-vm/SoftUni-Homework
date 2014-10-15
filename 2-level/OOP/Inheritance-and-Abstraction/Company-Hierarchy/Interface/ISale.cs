namespace CompanyHierarchy.Interface
{
    using System;

    interface ISale
    {
        string ProductName { get; set; }

        DateTime Date { get; }

        decimal Price { get; set; }
    }
}
