using HackerNews.Database.Connections;
using HackerNews.Database.Interfaces;

namespace HackerNews.Database.Sets
{
    public partial class Db(HackerNewsContext context) : IDb
    {
    }
}
