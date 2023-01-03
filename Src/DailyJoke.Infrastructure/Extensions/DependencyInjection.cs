using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DailyJoke.Application.Interfaces;
using DailyJoke.Infrastructure.Persistence;
using DailyJoke.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DailyJoke.Infrastructure.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<JokeDbContext>(options =>
                    options.UseInMemoryDatabase("CleanArchitectureDb"));
            }
            else
            {
                services.AddDbContext<JokeDbContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                        builder => builder.MigrationsAssembly(typeof(JokeDbContext).Assembly.FullName)));
            }

            services.AddScoped<IJokeDbContext>(provider => provider.GetRequiredService<JokeDbContext>());

            services.AddScoped<IDateTimeProvider, SystemDateTimeProvider>();

            services.AddScoped<JokeDbContextInitialiser>();

            return services;
        }
    }
}
