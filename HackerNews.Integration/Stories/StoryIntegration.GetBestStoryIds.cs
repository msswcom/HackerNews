using HackerNews.Integration.Connections;
using System.Net.Http.Json;

namespace HackerNews.Integration.Stories
{
    public partial class StoryIntegration
    {
        public async Task<List<long>> GetBestStoryIdsAsync()
        {
            var url = $"{HackerNewsUrl.BestStories}{HackerNewsExtension.Json}";

            var bestStoryIds = await hackerNewsIntegration
                .Http.GetFromJsonAsync<List<long>>
                (url, HackerNewsSerialization.Options);

            ArgumentNullException.ThrowIfNull(bestStoryIds);

            return bestStoryIds;
        }
    }
}
