using HackerNews.Models.Database;
using Microsoft.EntityFrameworkCore;

namespace HackerNews.Database.Connections
{
    public class HackerNewsContext(HackerNewsConnection hackerNewsConnection) : DbContext
    {
        public DbSet<Story> Story { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(hackerNewsConnection.ConnectionString);
        }
    }
}
