namespace CompanyHierarchy
{
    using System;
    using Interface;
    using Enumeration;

    class Project : IProject
    {
        string projectName;
        DateTime startDate;
        string details;
        ProjectState state;

        public Project(string projectName, DateTime startDate,
            string details, ProjectState state = ProjectState.Open)
        {
            this.ProjectName = projectName;
            this.StartDate = startDate;
            this.Details = details;
            this.State = state;
        }

        public string ProjectName
        {
            get
            {
                return this.projectName;
            }

            set
            {
                Validation.ValidateText("Project name", value);
                this.projectName = value;
            }
        }
        
        public DateTime StartDate
        {
            get
            {
                return this.startDate;
            }

           private set
            {
                this.startDate = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }

            set
            {
                Validation.ValidateText("Details", value);
                this.details = value;
            }
        }

        public Enumeration.ProjectState State
        {
            get
            {
                return this.state;
            }

           private set
            {
                this.state = value;
            }
        }

        public void CloseProject()
        {
            if (this.state == ProjectState.Open)
            {
                this.state = ProjectState.Closed;
            }
        }

        public override string ToString()
        {
            string str = string.Format("Project: {0} {1}, details: {2}, state: {3}",
                this.projectName, this.startDate, this.details, this.state);

            return str;
        }
    }
}
