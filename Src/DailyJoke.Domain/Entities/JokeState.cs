namespace DailyJoke.Domain.Entities
{
    public class JokeState
    {
        public int Id { get; set; }
        public DateTime? CurrentDate { get; set; }
        public int JokeId { get; set; }
    }
}
