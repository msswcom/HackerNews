using HackerNews.Models.Database;

namespace HackerNews.Orchestration.Interfaces
{
    public interface IStoryOrchestration
    {
        Task<List<Story>> GetBestStoriesAsync(int n);
        Task<Dictionary<long, Story>> GetStoriesAsync(List<long> ids);
        Task<Story> GetStoryAsync(long id);
        Task<List<Story>> UpdateBestStoriesAsync();
        Task<Dictionary<long, Story>> UpdateStoriesAsync(List<long> ids);
        Task<Story> UpdateStoryAsync(long id);
    }
}
