namespace School.Organisation
{
    using System;

    public abstract class ObjectName : ObjectDetail
    {
        private string name;

        public ObjectName(string name, string details = null)
            : base(details)
        {
            this.Name = name;
        }

        public string Name
        {
            get 
            {
                return this.name;
            }

            set 
            {
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty!");
                }

                this.name = value;
            }
        }

        public override string ToString()
        {
            string str = "";
            str = string.Format("{0}, ", this.name) + base.ToString();

            return str;
        }
    }
}
