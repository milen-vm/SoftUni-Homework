namespace School.Organisation
{
    using System;

    public abstract class ObjectDetail
    {
        private string details;

        public ObjectDetail(string detail = null)
        {
            this.Details = detail;
        }

        public string Details
        {
            get
            {
                return this.details;
            }

            set
            {
                if (value != null && (value == "" || value == " "))
                {
                    throw new ArgumentException("The details cannot be empty!");
                }

                this.details = value;
            }
        }

        public override string ToString()
        {
            string str = "";
            if (this.details != null)
            {
                str = string.Format("Details: {0}, ", this.details);
            }          

            return str;
        }
    }
}
