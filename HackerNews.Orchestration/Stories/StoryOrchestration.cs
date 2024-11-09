using HackerNews.Database.Interfaces;
using HackerNews.Integration.Interfaces;
using HackerNews.Orchestration.Interfaces;

namespace HackerNews.Orchestration.Stories
{
    public partial class StoryOrchestration(IStoryIntegration storyIntegration, IDb db, IStoryDb storyDb) : IStoryOrchestration
    {
    }
}
