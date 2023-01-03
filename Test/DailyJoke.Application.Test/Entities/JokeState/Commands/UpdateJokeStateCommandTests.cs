using DailyJoke.Application.Entities.JokeState.Commands;
using DailyJoke.Application.Exceptions;
using DailyJoke.Application.Test.TestInfra;
using DailyJoke.Infrastructure.Persistence;
using FluentAssertions;
using MediatR;
using Moq;

namespace DailyJoke.Application.Test.Entities.JokeState.Commands
{
    [TestFixture]
    internal class UpdateJokeStateCommandTests : BaseFixture
    {
        [Test, InMemoryDomainAutoData]
        public async Task ShouldRequireValidJokeStateId(UpdateJokeStateCommand command, Mock<IMediator> mediator, JokeDbContext jokeDbContext)
        {
            // Arrange

            var handler = new UpdateJokeStateCommandHandler(jokeDbContext, Mapper);
            mediator.Setup(m => m.Send(It.IsAny<UpdateJokeStateCommand>(), It.IsAny<CancellationToken>()))
                .Returns<UpdateJokeStateCommand, CancellationToken>(async (request, cancellationToken) => await handler.Handle(request, cancellationToken));

            // Act

            Func<Task> act = () => mediator.Object.Send(command);

            // Assert

            await act.Should().ThrowAsync<NotFoundException>();
        }
    }
}
