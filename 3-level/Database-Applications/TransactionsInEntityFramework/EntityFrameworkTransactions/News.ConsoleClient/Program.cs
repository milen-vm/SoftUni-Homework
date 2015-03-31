namespace News.ConsoleClient
{
    using System;
    using System.Linq;

    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    using News.Data;
    using News.Data.Migrations;

    class Program
    {
        static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<NewsDbContext, Configuration>());
            ReadAndEditFirstNews();
        }

        private static void ReadAndEditFirstNews()
        {
            var newsDb = new NewsDbContext();
            var firstNews = newsDb.News.First();

            if (firstNews != null)
            {
                Console.WriteLine("First news content:");
                Console.WriteLine(firstNews.Content);
            }
            else
            {
                Console.WriteLine("The news db is empty");
                return;
            }

            Console.WriteLine("\nInput new content:");
            var newContent = Console.ReadLine();

            firstNews.Content = newContent;
            try
            {
                newsDb.SaveChanges();
                Console.WriteLine("\nChanges successfully saved in the DB.");
            }
            catch (DbUpdateConcurrencyException)
            {

                Console.WriteLine("\nConflict!\nThe content is already changed.\n");
                ReadAndEditFirstNews();
            }
        }
    }
}
