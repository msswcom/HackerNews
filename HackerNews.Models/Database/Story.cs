using System.ComponentModel.DataAnnotations.Schema;

namespace HackerNews.Models.Database
{
    public class Story
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public required long Id { get; set; }
        public required string Title { get; set; }
        public string? Uri { get; set; }
        public required string PostedBy { get; set; }
        public required DateTime Time { get; set; }
        public required int Score { get; set; }
        public required int CommentCount { get; set; }
    }
}
