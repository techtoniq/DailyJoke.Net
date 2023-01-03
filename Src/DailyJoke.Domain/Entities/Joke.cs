namespace DailyJoke.Domain.Entities
{
    public class Joke
    {
        public int Id { get; set; }
        public string? Text { get; set; }
        public int UsageCount { get; set; }
    }
}
