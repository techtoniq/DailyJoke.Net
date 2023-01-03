using DailyJoke.Application.Entities.Jokes.Commands;
using DailyJoke.Application.Exceptions;
using DailyJoke.Application.Test.TestInfra;
using DailyJoke.Infrastructure.Persistence;
using FluentAssertions;
using MediatR;
using Moq;

namespace DailyJoke.Application.Test.Entities.Jokes.Commands
{
    [TestFixture]
    internal class UpdateJokeCommandTests : BaseFixture
    {
        [Test, InMemoryDomainAutoData]
        public async Task ShouldRequireValidJokeId(UpdateJokeCommand command, Mock<IMediator> mediator, JokeDbContext jokeDbContext)
        {
            // Arrange

            var handler = new UpdateJokeCommandHandler(jokeDbContext, Mapper);
            mediator.Setup(m => m.Send(It.IsAny<UpdateJokeCommand>(), It.IsAny<CancellationToken>()))
                .Returns<UpdateJokeCommand, CancellationToken>(async (request, cancellationToken) => await handler.Handle(request, cancellationToken));

            // Act

            Func<Task> act = () => mediator.Object.Send(command);

            // Assert

            await act.Should().ThrowAsync<NotFoundException>();
        }
    }
}
