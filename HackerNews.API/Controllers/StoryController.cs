using HackerNews.Models.Database;
using HackerNews.Orchestration.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HackerNews.API.Controllers
{
    [ApiController]
    public class StoryController(IStoryOrchestration storyOrchestration) : ControllerBase
    {
        [HttpGet("/best-stories/{n}")]
        public async Task<List<Story>> GetBestStoriesAsync(int n)
        {
            return await storyOrchestration.GetBestStoriesAsync(n);
        }
    }
}
