using DailyJoke.Application.Entities.Jokes.Queries;
using DailyJoke.Application.Test.TestInfra;
using DailyJoke.Domain.Entities;
using DailyJoke.Infrastructure.Persistence;
using FluentAssertions;
using MediatR;
using Moq;

namespace DailyJoke.Application.Test.Entities.Jokes.Queries
{
    [TestFixture]
    internal class GetAllJokesQueryTests : BaseFixture
    {
        [Test, InMemoryDomainAutoData]
        public async Task ShouldReturnAllJokesLowestUsageFirst(GetAllJokesQuery query, Mock<IMediator> mediator, JokeDbContext jokeDbContext, List<Joke> jokes)
        {
            // Arrange

            var handler = new GetAllJokesQueryHandler(jokeDbContext, Mapper);
            mediator.Setup(m => m.Send(It.IsAny<GetAllJokesQuery>(), It.IsAny<CancellationToken>()))
                .Returns<GetAllJokesQuery, CancellationToken>(async (request, cancellationToken) => await handler.Handle(request, cancellationToken));
            jokeDbContext.Jokes.AddRange(jokes);
            await jokeDbContext.SaveChangesAsync();

            // Act

            var result = await mediator.Object.Send(query);

            // Assert

            result.Should().NotBeNull();
            result.Should().HaveCount(jokes.Count);
            result.Should().BeInAscendingOrder(j => j.UsageCount);
        }
    }
}
