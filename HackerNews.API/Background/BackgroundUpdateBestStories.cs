using HackerNews.Orchestration.Interfaces;

namespace HackerNews.API.Background
{
    public class BackgroundUpdateBestStories(IStoryOrchestration storyOrchestration) : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                var delay1h = new TimeSpan(1, 0, 0);

                try
                {
                    await storyOrchestration.UpdateBestStoriesAsync();

                    await Task.Delay(delay1h, cancellationToken);
                }
                catch
                {
                    await Task.Delay(delay1h, cancellationToken);
                }
            }
        }
    }
}
