namespace News.Data.Migrations
{
    using System.Linq;

    using System.Data.Entity.Migrations;

    using News.Model;

    public sealed class Configuration : DbMigrationsConfiguration<NewsDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            this.ContextKey = "News.Data.NewsDbContext";
        }

        protected override void Seed(NewsDbContext context)
        {
            if (context.News.Any())
            {
                return;
            }

            var newsOne = new News()
            {
                Content = "Is now open for an internship in a German company ProLeiT. This is the first experience" +
                    " abroad, which SoftUni could offer in partnership with its partners in Germany."
            };

            context.News.Add(newsOne);
            context.SaveChanges();
        }
    }
}
