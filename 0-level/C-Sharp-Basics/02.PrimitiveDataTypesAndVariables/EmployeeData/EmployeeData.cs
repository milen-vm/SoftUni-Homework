using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Ivan";
        string lastName = "Ivanov";
        byte age = 30;
        char gender = 'm';
        ulong personal_ID = 8306112507;
        uint employeeNumber = 27565233;
        Console.WriteLine("Employee data");
        Console.WriteLine();
        Console.WriteLine("First name: " + firstName);
        Console.WriteLine("Last name: " + lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("Personal ID number: " + personal_ID);
        Console.WriteLine("Unique employee number: " + employeeNumber);
    }
}