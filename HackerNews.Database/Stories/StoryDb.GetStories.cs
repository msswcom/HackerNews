using HackerNews.Models.Database;
using Microsoft.EntityFrameworkCore;

namespace HackerNews.Database.Stories
{
    public partial class StoryDb
    {
        /// <summary>
        /// Gets stories from the database
        /// </summary>
        /// <param name="ids">Story ids</param>
        /// <returns>Dictionary of stories</returns>
        public async Task<Dictionary<long, Story>> GetStoriesAsync(List<long> ids)
        {
            var stories = await context.Story.Where(o => ids.Contains(o.Id)).ToDictionaryAsync(o => o.Id, o => o);

            return stories;
        }
    }
}
