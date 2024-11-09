using HackerNews.Integration.Connections;
using HackerNews.Models.Converters;
using HackerNews.Models.Database;
using HackerNews.Models.Integration;
using System.Net.Http.Json;

namespace HackerNews.Integration.Stories
{
    public partial class StoryIntegration
    {
        public async Task<Story> GetStoryAsync(long id)
        {
            var url = $"{HackerNewsUrl.Item}/{id}{HackerNewsExtension.Json}";

            var integrationStory = await hackerNewsIntegration
                .Http.GetFromJsonAsync<IntegrationStory>
                (url, HackerNewsSerialization.Options);

            ArgumentNullException.ThrowIfNull(integrationStory);

            var story = StoryConverter.Convert(integrationStory);

            return story;
        }
    }
}
