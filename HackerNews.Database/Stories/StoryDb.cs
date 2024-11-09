using HackerNews.Database.Connections;
using HackerNews.Database.Interfaces;

namespace HackerNews.Database.Stories
{
    public partial class StoryDb(HackerNewsContext context) : IStoryDb
    {
    }
}
