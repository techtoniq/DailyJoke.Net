using DailyJoke.Application.Entities.JokeState.Commands;
using DailyJoke.Application.Test.TestInfra;
using DailyJoke.Infrastructure.Persistence;
using FluentAssertions;
using MediatR;
using Moq;

namespace DailyJoke.Application.Test.Entities.JokeState.Commands
{
    [TestFixture]
    internal class CreateJokeStateCommandTests : BaseFixture
    {
        [Test, InMemoryDomainAutoData]
        public async Task ShouldReturnJokeStateId(CreateJokeStateCommand command, Mock<IMediator> mediator, JokeDbContext jokeDbContext)
        {
            // Arrange

            var handler = new CreateJokeStateCommandHandler(jokeDbContext, Mapper);
            mediator.Setup(m => m.Send(It.IsAny<CreateJokeStateCommand>(), It.IsAny<CancellationToken>()))
                .Returns<CreateJokeStateCommand, CancellationToken>(async (request, cancellationToken) => await handler.Handle(request, cancellationToken));

            // Act

            var result = await mediator.Object.Send(command);

            // Assert

            result.Should().BeGreaterThan(0);
        }
    }
}
