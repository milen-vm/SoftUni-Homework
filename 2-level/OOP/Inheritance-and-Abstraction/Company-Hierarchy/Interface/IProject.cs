namespace CompanyHierarchy.Interface
{
    using System;
    using Enumeration;

    interface IProject
    {
        string ProjectName { get; set; }

        DateTime StartDate { get; }

        string Details { get; set; }

        ProjectState State { get; }

        void CloseProject();
    }
}
