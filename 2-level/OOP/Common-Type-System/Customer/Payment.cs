namespace Customer
{
    using System;

    public class Payment : ICloneable
    {
        private string productName;
        private decimal price;

        public Payment(string productName, decimal price)
        {
            this.ProductName = productName;
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

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                Validation.ValidatePrice("Product price", value);
                this.price = value;
            }
        }

        public object Clone()
        {
            Payment clonedPayments = new Payment(
                (string)this.productName.Clone(),
                this.price);

            return clonedPayments;
        }
    }
}
