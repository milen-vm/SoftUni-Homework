namespace Customer
{
    using System;
    using System.Collections.Generic;
    using Enumeration;

    public class Customer : ICloneable, IComparable<Customer>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private long id;
        private string address;
        private string phone;
        private string email;
        private List<Payment> payments;
        private CustomerType type;

        public Customer(string firstName,
            string middleName,
            string lastName,
            long id,
            string address,
            string phone,
            string email,
            List<Payment> payments,
            CustomerType type
            )
        {
            this.FirstName = firstName;
            this.MidleName = middleName;
            this.LastName = lastName;
            this.ID = id;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.Payments = payments;
            this.Type = type;
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

        public string MidleName
        {
            get
            {
                return this.middleName;
            }

            set
            {
                Validation.ValidateText("Middle name", value);
                this.middleName = value;
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

        public long ID
        {
            get
            {
                return this.id;
            }

            set
            {
                Validation.ValidateID(value);
                this.id = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }

            set
            {
                Validation.ValidateText("Address", value);
                this.address = value;
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }

            set
            {
                this.phone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                this.email = value;
            }
        }

        public List<Payment> Payments
        {
            get
            {
                return this.payments;
            }

            set
            {
                if (value.Count == 0)
                {
                    string mesage = "Payment's list cannot be empty!";
                    throw new ArgumentException(mesage);
                }

                this.payments = value;
            }
        }

        public CustomerType Type
        {
            get
            {
                return this.type;
            }

            set
            {
                this.type = value;
            }
        }

        public override string ToString()
        {
            string str = this.firstName + " " +
                this.middleName + " " +
                this.lastName + "\nID" +
                this.id + "\nAddress" +
                this.address + "\nPhone" +
                this.phone + ", Email: " +
                this.email + "\nCustomer type: " + 
                this.type;

            return str;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Customer customer = obj as Customer;
            if ((Object)customer == null)
            {
                return false;
            }

            bool isEqual = this.id.Equals(customer.id);

            return isEqual;
        }

        public override int GetHashCode()
        {
            int hashCode = (int)this.id ^ (int)(this.id >> 32);

            return hashCode;
        }

        public static bool operator ==(Customer customerA, Customer customerB)
        {
            if (ReferenceEquals(customerA, customerB))
            {
                return true;
            }

            if (((object)customerA == null) || ((object)customerB == null))
            {
                return false;
            }

            bool isEqual = customerA.id == customerB.id;

            return isEqual;
        }

        public static bool operator !=(Customer customerA, Customer customerB)
        {
            bool isDifferent = !(customerA == customerB);

            return isDifferent;
        }

        public object Clone()
        {
            List<Payment> clonedPayments = new List<Payment>();
            foreach (var item in this.payments)
            {
                clonedPayments.Add((Payment)item.Clone());
            }

            object clonedCustomer = new Customer(
                (string)this.firstName.Clone(),
                (string)this.middleName.Clone(),
                (string)this.lastName.Clone(),
                this.id,
                (string)this.address.Clone(),
                (string)this.phone.Clone(),
                (string)this.email.Clone(),
                clonedPayments,
                this.type);

            return clonedCustomer;
        }

        public int CompareTo(Customer other)
        {
            string thisFullName = this.FirstName + " " + this.MidleName + " " + this.LastName;
            string otherFullName = other.FirstName + " " + other.MidleName + " " + other.LastName;

            if (thisFullName == otherFullName)
            {
                return this.id.CompareTo(other.id);
            }

            return thisFullName.CompareTo(otherFullName);
        }
    }
}
