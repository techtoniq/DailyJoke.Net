using DailyJoke.Application.Mappings;
using DailyJoke.Domain.Entities;

namespace DailyJoke.Application.Entities.Jokes.Queries
{
    public class JokeDto : IMapFrom<Joke>
    {
        public int Id { get; set; }
        public string? Text { get; set; }
        public int UsageCount { get; set; }
    }
}
