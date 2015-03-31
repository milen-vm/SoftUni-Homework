namespace StudentSystem.ConsoleClient
{
    using System;
    using System.Linq;

    using System.Data.Entity;

    using StudentSystem.Model;
    using StudentSystem.Data;
    using StudentSystem.Data.Migrations;

    class StudentSystemConsoleClient
    {
        static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemDbContext, Configuration>());
            var studentSystemDb = new StudentSystemDbContext();
            var student = studentSystemDb.Students.FirstOrDefault();
            if (student != null)
            {
                Console.WriteLine(student.Name + " " + student.PhoneNumber);
            }

            var courseOne = new Course()
            {
                Description = "Programing Basics",
                Name = "C# basics",
                StartDate = new DateTime(2015, 3, 18),
                EndDate = new DateTime(2015, 5, 18),
                Price = 50m
            };

            var resourceOne = new Resource()
            {
                Name = "C# Programing Basics",
                Link = "http://www.introprogramming.info/",
                Type = ResourceType.Other
            };

            courseOne.Resources.Add(resourceOne);
            studentSystemDb.Courses.Add(courseOne);

            var studentOne = new Student()
            {
                Name = "Ivan Ivanov",
                RegistrationDate = DateTime.Now
            };

            var homeworkOne = new Homework()
            {
                Content = "22 problems C#",
                SubmittedDate = DateTime.Now.AddDays(15),
                Type = ContentType.Zip
            };

            studentOne.Homeworks.Add(homeworkOne);
            studentSystemDb.Students.Add(studentOne);

            studentSystemDb.SaveChanges();

            var students = studentSystemDb.Students;
            foreach (var st in students)
            {
                var studentId = st.Id;
                Console.WriteLine(st.Name + " " + st.PhoneNumber);
                //var stHomework = studentSystemDb.Homeworks
                //    .Where(h => h.StudentId == studentId)
                //    .ToList();

                var stHomework = st.Homeworks.ToList();

                foreach (var hw in stHomework)
                {
                    Console.WriteLine(hw.Content + " " + hw.SubmittedDate);
                }
            }
        }
    }
}
