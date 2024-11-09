using HackerNews.Models.Database;

namespace HackerNews.Integration.Interfaces
{
    public interface IStoryIntegration
    {
        Task<List<long>> GetBestStoryIdsAsync();
        Task<Story> GetStoryAsync(long id);
    }
}
