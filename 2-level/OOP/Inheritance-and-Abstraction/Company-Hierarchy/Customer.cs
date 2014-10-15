namespace CompanyHierarchy
{
    using System;
    using Interface;

    class Customer : Person, ICustomer
    {
        private decimal netPurchaseAmount;

        public Customer(int id, string firsName, string lastName, decimal netPurchaseAmount)
            : base(id, firsName, lastName)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        public decimal NetPurchaseAmount
        {
            get
            {
                return this.netPurchaseAmount;
            }

            set
            {
                Validation.ValidateAmount("Purchase amount", value);
                this.netPurchaseAmount = value;
            }
        }

        public override string ToString()
        {
            string str = string.Format("{0}: {1}, Net purchase amount: {2}",this.GetType().Name, base.ToString(), this.netPurchaseAmount);
            return str;
        }
    }
}
