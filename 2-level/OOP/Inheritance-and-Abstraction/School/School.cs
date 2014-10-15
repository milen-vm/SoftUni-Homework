namespace School
{    
    using System;
    using Organisation;
    using System.Collections.Generic;

    class School
    {

        static void Main()
        {
            Student studentOne = new Student("Ivan Hristov", 14, "Exelent student!");
            Console.WriteLine(studentOne);

            Student studentTwo = new Student("Petar Georgiev", 25);
            Console.WriteLine(studentTwo);

            Student studentThree = new Student("Dimitar Dimitrov", 23, "Exelent student!");
            Console.WriteLine(studentThree);

            Student studentFour = new Student("Maria Antonova", 17, "Average student!");
            Console.WriteLine(studentFour);
                     
            Console.WriteLine();

            List<Student> studentsList = new List<Student>() 
            { 
                studentOne,
                studentTwo,
                studentThree,
                studentFour
            };
            Discipline disciplineOne = new Discipline("OOP", 14, studentsList, "Very hard to learn :)");
            Console.WriteLine(disciplineOne);
            Console.WriteLine();
            Discipline disciplineTwo = new Discipline("High Quality Code", 17, studentsList);
            Console.WriteLine(disciplineTwo);

            Console.WriteLine();

            List<Discipline> disciplinesList = new List<Discipline>()
            {
                disciplineOne,
                disciplineTwo
            };
            Teacher nakov = new Teacher("Svetlin Nakov", disciplinesList, "Master trainer and developer");
            Console.WriteLine(nakov);
            Console.WriteLine();
            Teacher vladi = new Teacher("Vladislav Karamfilov", disciplinesList);
            Console.WriteLine(vladi);

            Console.WriteLine();

            List<Teacher> teachersList = new List<Teacher>()
            {
                nakov,
                vladi
            };
            Class classOne = new Class("2-level", teachersList, studentsList, "The first class in SoftUni");
            Console.WriteLine(classOne);
        }
    }

}
