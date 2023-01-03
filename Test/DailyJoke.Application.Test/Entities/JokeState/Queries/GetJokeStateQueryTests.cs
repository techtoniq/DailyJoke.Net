using DailyJoke.Application.Entities.JokeState.Queries;
using DailyJoke.Application.Test.TestInfra;
using DailyJoke.Infrastructure.Persistence;
using FluentAssertions;
using MediatR;
using Moq;
using NUnit.Framework;

namespace DailyJoke.Application.Test.Entities.JokeState.Queries
{
    [TestFixture]
    internal class GetJokeStateQueryTests : BaseFixture
    {

        [Test, InMemoryDomainAutoData]
        public async Task ShouldReturnJokeState(GetJokeStateQuery query, Mock<IMediator> mediator, JokeDbContext jokeDbContext, Domain.Entities.JokeState jokeState)
        {
            // Arrange

            var handler = new GetJokeStateQueryHandler(jokeDbContext, Mapper);
            mediator.Setup(m => m.Send(It.IsAny<GetJokeStateQuery>(), It.IsAny<CancellationToken>()))
                .Returns<GetJokeStateQuery, CancellationToken>(async (request, cancellationToken) => await handler.Handle(request, cancellationToken));
            jokeDbContext.JokeState.Add(jokeState);
            await jokeDbContext.SaveChangesAsync();

            // Act

            var result = await mediator.Object.Send(query);

            // Assert

            result.Should().NotBeNull();
            result.Id.Should().Be(jokeState.Id);
            result.CurrentDate.Should().Be(jokeState.CurrentDate);
            result.JokeId.Should().Be(jokeState.JokeId);
        }
    }
}
