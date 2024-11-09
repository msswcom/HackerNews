using HackerNews.Integration.Connections;
using HackerNews.Integration.Interfaces;

namespace HackerNews.Integration.Stories
{
    public partial class StoryIntegration(HackerNewsIntegration hackerNewsIntegration) : IStoryIntegration
    {
    }
}
