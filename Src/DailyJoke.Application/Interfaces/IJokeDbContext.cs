using DailyJoke.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DailyJoke.Application.Interfaces
{
    public interface IJokeDbContext
    {
        DbSet<Joke> Jokes { get; }
        DbSet<JokeState> JokeState { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
