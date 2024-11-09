using HackerNews.Models.Collections;
using HackerNews.Models.Database;
using HackerNews.Models.Validations;

namespace HackerNews.Orchestration.Stories
{
    public partial class StoryOrchestration
    {
        /// <summary>
        /// Gets n best stories from the local database and from the remote API if they are not already in the database
        /// </summary>
        /// <param name="n"></param>
        /// <returns>n best stories</returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public async Task<List<Story>> GetBestStoriesAsync(int n)
        {
            var bestStoryIds = await storyIntegration.GetBestStoryIdsAsync();

            if (n.GreaterThanCount(bestStoryIds))
            {
                throw new IndexOutOfRangeException($"Maximum number of best stories is {bestStoryIds.Count}");
            }

            var storyIds = bestStoryIds[..n];
            var storiesInDb = await storyDb.GetStoriesAsync(storyIds);

            var storyIdsInDb = storiesInDb.Keys.ToList();
            var storyIdsNotInDb = storyIds.Except(storyIdsInDb).ToList();

            var storiesNotInDb = await GetStoriesAsync(storyIdsNotInDb);
            var stories = storiesInDb.Union(storiesNotInDb).ToDictionary(o => o.Key, o => o.Value);

            var bestStories = Collection.GetFirstOrderedItems(n, bestStoryIds, stories);

            return bestStories;
        }
    }
}
