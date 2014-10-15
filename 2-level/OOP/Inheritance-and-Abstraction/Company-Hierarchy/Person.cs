namespace CompanyHierarchy
{
    using System;
    using Interface;

    public abstract class Person : IPerson
    {
        private int id;
        private string firstName;
        private string lastName;

        public Person(int id, string firsName, string lastName)
        {
            this.Id = id;
            this.FirstName = firsName;
            this.LastName = lastName;
        }



        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                Validation.ValidateAmount("Id", value);
                this.id = value;
            }
        }

        public string FirstName
        {
            get
            {
               return this.firstName;
            }

            set
            {
                Validation.ValidateText("First name", value);
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                Validation.ValidateText("Last name", value);
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            string str = string.Format("{0} {1}, ID {2}", this.FirstName, this.LastName, this.Id);

            return str;
        }
    }
}
