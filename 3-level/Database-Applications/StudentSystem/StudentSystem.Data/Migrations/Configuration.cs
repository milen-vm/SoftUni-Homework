namespace StudentSystem.Data.Migrations
{
    using System;
    using System.Linq;
    
    using System.Data.Entity.Migrations;

    using StudentSystem.Model;

    public sealed class Configuration : DbMigrationsConfiguration<StudentSystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            this.ContextKey = "StudentSystem.Data.StudentSystemDbContext";
        }

        protected override void Seed(StudentSystemDbContext context)
        {
            if (context.Students.Any())
            {
                return;
            }

            var newStudent = CreateStudent();
            var newCourse = CreateCourse();
            var newResourse = createResource();
            var newHomework = CreateHomework();   

            newCourse.Resources.Add(newResourse);
            newCourse.Homeworks.Add(newHomework);
            newStudent.Courses.Add(newCourse);
            newStudent.Homeworks.Add(newHomework);

            context.Students.Add(newStudent);
            context.SaveChanges();
        }

        private Student CreateStudent()
        {
            var student = new Student()
            {
                Birthday = new DateTime(1988, 4, 23),
                Name = "Maria Ivanova",
                PhoneNumber = "0458-965-78",
                RegistrationDate = DateTime.Now
            };

            return student;
        }

        private Course CreateCourse()
        {
            var course = new Course()
            {
                Description =
                    "В курса \"Database Applications\" ще се изучава работата с ORM технологии (Object-Relational Mapping)," +
                        " XML, JSON, достъп до нерелационни бази данни (като MongoDB и Redis) и инструменти и технологии," +
                        " улесняващи практическата работа с данни и изграждане на database приложения с езици от високо ниво" +
                        " (като C#, Java и PHP).",
                Name = "Database Applications",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(28),
                Price = 100m
            };

            return course;
        }

        private Homework CreateHomework()
        {
            var homework = new Homework()
            {
                Content = "Write a seed method that fills the database with sample data (randomly generated).",
                SubmittedDate = DateTime.Now.AddDays(10),
                Type = ContentType.Zip
            };

            return homework;
        }

        private Resource createResource()
        {
            var resource = new Resource()
            {
                Name = "Course page",
                Link = "https://softuni.bg/trainings/21/Database-Applications-Mar-2015",
                Type = ResourceType.Web,

            };

            return resource;
        }
    }
}
