using DailyJoke.Application.Interfaces;
using DailyJoke.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DailyJoke.Infrastructure.Persistence
{
    public class JokeDbContext : DbContext, IJokeDbContext
    {
        public DbSet<Joke> Jokes => Set<Joke>();
        public DbSet<JokeState> JokeState => Set<JokeState>();
        public JokeDbContext(DbContextOptions<JokeDbContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
             *  @ToDo: InMemoryDatabase in unit test doesn't like the entity not having a key. Needs addressing.
            modelBuilder
                .Entity<JokeState>(
                    e =>
                    {
                        e.HasNoKey();
                    });
            */
            base.OnModelCreating(modelBuilder);
        }
    }
}
