namespace Customer
{
    using System;
    using System.Collections.Generic;
    using Enumeration;

    class CustomerTest
    {
        static void Main()
        {
            List<Payment> payments = new List<Payment>()
            {
                new Payment("Potatoes", 9.45m),
                new Payment("Tomatoes", 17.6m)
            };

            Customer originalCustomer = new Customer("Ivan", "Ivanov", "Ivanov", 9501234436, "Sofia jk. Mladost",
                "0789-456-723", "ivan@abv.bg", payments, CustomerType.Regular);

            Customer clonedCustomer = (Customer)originalCustomer.Clone();

            originalCustomer.Type = CustomerType.Golden;
            originalCustomer.FirstName = "Petar";
            
            Console.WriteLine("Original customer:");
            Console.WriteLine(originalCustomer);
            Console.WriteLine();
            Console.WriteLine("Cloned customer:");
            Console.WriteLine(clonedCustomer);
            Console.WriteLine();

            Customer thirdCustomer = new Customer("Anna", "Petrova", "Dimitrova", 8806056861, "Sofia jk. Mladost",
                "02-94-33-215", "anna@abv.bg", payments, CustomerType.Diamond);

            List<Customer> customers = new List<Customer>()
            {
                originalCustomer,
                clonedCustomer,
                thirdCustomer
            };
            customers.Sort();       // using IComparable implementation
            Console.WriteLine("Sorted customers:");
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
                Console.WriteLine();
            }
            
        }
    }
}
