using HackerNews.Models.Database;
using HackerNews.Models.Integration;

namespace HackerNews.Models.Converters
{
    public class StoryConverter
    {
        public static Story Convert(IntegrationStory integrationStory)
        {
            var story = new Story
            {
                Id = integrationStory.Id,
                Title = integrationStory.Title,
                Uri = integrationStory.Url,
                PostedBy = integrationStory.By,
                Time = new DateTime(1970, 1, 1).AddMilliseconds(integrationStory.Time),
                Score = integrationStory.Score,
                CommentCount = integrationStory.Descendants
            };

            return story;
        }
    }
}
