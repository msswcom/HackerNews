using HackerNews.Models.Database;

namespace HackerNews.Orchestration.Stories
{
    public partial class StoryOrchestration
    {
        /// <summary>
        /// Gets stories from remote API and updates them in the database
        /// </summary>
        /// <param name="ids">Story ids</param>
        /// <returns>Dictionary of stories</returns>
        public async Task<Dictionary<long, Story>> UpdateStoriesAsync(List<long> ids)
        {
            var stories = new Dictionary<long, Story>();

            foreach (var id in ids)
            {
                var story = await UpdateStoryAsync(id);

                stories.Add(id, story);
            }

            return stories;
        }
    }
}
