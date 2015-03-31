namespace News.Data
{
    using System.Data.Entity;
    using News.Model;

    public class NewsDbContext : DbContext
    {
        public NewsDbContext()
            : base("News")
        { 
        }

        public DbSet<News> News { get; set; }
    }
}
