using HackerNews.Models.Database;

namespace HackerNews.Orchestration.Stories
{
    public partial class StoryOrchestration
    {
        /// <summary>
        /// Gets story from remote API and stores it in the database
        /// </summary>
        /// <param name="id">Story id</param>
        /// <returns>Story</returns>
        public async Task<Story> GetStoryAsync(long id)
        {
            var story = await storyIntegration.GetStoryAsync(id);

            await db.InsertAsync(story);

            return story;
        }
    }
}
