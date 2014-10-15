using System;

class StudentClassTest
{
    static void Main()
    {
        Student student = new Student("Peter", 22);
       
        student.Name = "Maria";
        student.Age = 19;
    }
}
