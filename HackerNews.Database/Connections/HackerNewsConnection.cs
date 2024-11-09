using Microsoft.Extensions.Configuration;

namespace HackerNews.Database.Connections
{
    public class HackerNewsConnection
    {
        public string ConnectionString { get; }

        public HackerNewsConnection(IConfiguration configuration)
        {
            var connectionString = configuration[HackerNewsDatabase.Connection];

            ArgumentException.ThrowIfNullOrEmpty(connectionString);

            ConnectionString = connectionString;
        }
    }
}
