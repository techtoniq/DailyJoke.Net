using AutoMapper;
using DailyJoke.Application.Exceptions;
using DailyJoke.Application.Interfaces;
using DailyJoke.Domain.Entities;
using MediatR;

namespace DailyJoke.Application.Entities.Jokes.Commands
{
    public class UpdateJokeCommand : IRequest
    {
        public int Id { get; init; }
        public int UsageCount { get; init; }
    }

    public class UpdateJokeCommandHandler : IRequestHandler<UpdateJokeCommand>
    {
        private readonly IJokeDbContext _jokeDbContext;
        private readonly IMapper _mapper;

        public UpdateJokeCommandHandler(IJokeDbContext jokeDbContext, IMapper mapper)
        {
            _jokeDbContext = jokeDbContext;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateJokeCommand request, CancellationToken cancellationToken)
        {
            var entity = await _jokeDbContext.Jokes
                        .FindAsync(new object[] { request.Id }, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Joke), request.Id);
            }

            entity.UsageCount = request.UsageCount;

            await _jokeDbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
