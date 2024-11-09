
namespace HackerNews.Models.Integration
{
    public class IntegrationStory
    {
        public required long Id { get; set; }
        public required string Title { get; set; }
        public string? Url { get; set; }
        public required string By { get; set; }
        public required long Time { get; set; }
        public required int Score { get; set; }
        public required int Descendants { get; set; }
    }
}
