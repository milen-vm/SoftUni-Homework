namespace CompanyHierarchy
{
    using System;
    using Interface;

    public class Sale : ISale
    {
        private string productName;
        private DateTime date;
        private decimal price;

        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public string ProductName
        {
            get
            {
                return this.productName;
            }

            set
            {
                Validation.ValidateText("Product name", value);
                this.productName = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }

           private set
            {
                this.date = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                Validation.ValidateAmount("Price", value);
                this.price = value;
            }
        }

        public override string ToString()
        {
            string str = string.Format("Name: {0}, date: {1}, price: {2}", this.productName, this.date, this.price);

            return str;
        }
    }
}
