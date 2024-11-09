using HackerNews.Models.Database;

namespace HackerNews.Database.Interfaces
{
    public interface IStoryDb
    {
        Task<Dictionary<long, Story>> GetStoriesAsync(List<long> ids);
    }
}
