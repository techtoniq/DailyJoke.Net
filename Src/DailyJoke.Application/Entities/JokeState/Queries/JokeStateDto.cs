using DailyJoke.Application.Mappings;

namespace DailyJoke.Application.Entities.JokeState.Queries
{
    public class JokeStateDto : IMapFrom<Domain.Entities.JokeState>
    {
        public int Id { get; set; }
        public DateTime? CurrentDate { get; set; }
        public int JokeId { get; set; }

        public static explicit operator JokeStateDto(Domain.Entities.JokeState jokeState)
        {
            return new JokeStateDto
            {
                Id = jokeState.Id,
                CurrentDate = jokeState.CurrentDate,
                JokeId = jokeState.JokeId
            };
        }
    }
}
