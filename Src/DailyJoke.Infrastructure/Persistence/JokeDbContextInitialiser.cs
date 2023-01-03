using DailyJoke.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DailyJoke.Infrastructure.Persistence
{
    public class JokeDbContextInitialiser
    {
        private readonly ILogger<JokeDbContextInitialiser> _logger;
        private readonly JokeDbContext _context;

        public JokeDbContextInitialiser(ILogger<JokeDbContextInitialiser> logger, JokeDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task InitialiseAsync()
        {
            try
            {
                if (_context.Database.IsSqlServer())
                {
                    await _context.Database.MigrateAsync();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while initialising the database.");
                throw;
            }
        }

        public async Task SeedAsync()
        {
            try
            {
                await TrySeedAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while seeding the database.");
                throw;
            }
        }

        public async Task TrySeedAsync()
        {
            // Example data
            if (!_context.Jokes.Any())
            {
                _context.Jokes.Add(new Joke
                {
                    Text = "I got a pair of mittens as my Secret Santa present at work. I think I know who they're from, but I don't want to point any fingers.",
                });

                await _context.SaveChangesAsync();
            }
        }
    }
}
