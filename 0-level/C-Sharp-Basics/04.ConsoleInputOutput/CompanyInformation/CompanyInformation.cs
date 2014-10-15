using System;

class CompanyInformation
{
    static void Main()
    {
        Console.Write("Enter a company name: ");
        string company = Console.ReadLine();
        Console.Write("Enter the address: ");
        string address = Console.ReadLine();
        Console.Write("Phone number: ");
        object phoneCompany = Console.ReadLine();
        Console.Write("Fax number: ");
        object faxCompany = Console.ReadLine();
        Console.Write("Web site: ");
        string web = Console.ReadLine();
        Console.Write("First name of the manager: ");
        string firstName = Console.ReadLine();
        Console.Write("Last name of the manager: ");
        string lastName = Console.ReadLine();
        Console.Write("The age of the manager: ");
        int ageManager = int.Parse(Console.ReadLine());
        Console.Write("Phone number: ");
        object phoneManager = Console.ReadLine();
        Console.WriteLine("Company name: " + company);
        Console.WriteLine("Address: " + address);
        Console.WriteLine("Phone number: " + phoneCompany);
        Console.WriteLine("Fax number: " + faxCompany);
        Console.WriteLine("Web site: " + web);
        Console.WriteLine("Manager: {0} {1}", firstName, lastName);
        Console.WriteLine("Age: " + ageManager);
        Console.WriteLine("Phone number: " + phoneManager);
    }
}