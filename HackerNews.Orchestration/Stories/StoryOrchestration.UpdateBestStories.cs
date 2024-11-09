using HackerNews.Models.Collections;
using HackerNews.Models.Database;

namespace HackerNews.Orchestration.Stories
{
    public partial class StoryOrchestration
    {
        /// <summary>
        /// Updates best stories from the local database and from the remote API if they are not already in the database
        /// </summary>
        /// <returns>Best stories</returns>
        public async Task<List<Story>> UpdateBestStoriesAsync()
        {
            var bestStoryIds = await storyIntegration.GetBestStoryIdsAsync();

            var storyIds = bestStoryIds;
            var storiesInDb = await storyDb.GetStoriesAsync(storyIds);

            var storyIdsInDb = storiesInDb.Keys.ToList();
            var storyIdsNotInDb = storyIds.Except(storyIdsInDb).ToList();

            storiesInDb = await UpdateStoriesAsync(storyIdsInDb);
            var storiesNotInDb = await GetStoriesAsync(storyIdsNotInDb);
            var stories = storiesInDb.Union(storiesNotInDb).ToDictionary(o => o.Key, o => o.Value);

            var bestStories = Collection.GetFirstOrderedItems(bestStoryIds.Count, bestStoryIds, stories);

            return bestStories;
        }
    }
}
