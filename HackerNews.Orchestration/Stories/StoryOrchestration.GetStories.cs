using HackerNews.Models.Database;

namespace HackerNews.Orchestration.Stories
{
    public partial class StoryOrchestration
    {
        /// <summary>
        /// Gets stories from remote API and stores them in the database
        /// </summary>
        /// <param name="ids">Story ids</param>
        /// <returns>Dictionary of stories</returns>
        public async Task<Dictionary<long, Story>> GetStoriesAsync(List<long> ids)
        {
            var stories = new Dictionary<long, Story>();

            foreach (var id in ids)
            {
                var story = await GetStoryAsync(id);

                stories.Add(id, story);
            }

            return stories;
        }
    }
}
