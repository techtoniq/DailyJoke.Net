using AutoMapper;
using DailyJoke.Application.Exceptions;
using DailyJoke.Application.Interfaces;
using MediatR;

namespace DailyJoke.Application.Entities.JokeState.Commands
{
    public class UpdateJokeStateCommand : IRequest
    {
        public int Id { get; init; }
        public DateTime? CurrentDate { get; init; }
        public int JokeId { get; init; }
    }

    public class UpdateJokeStateCommandHandler : IRequestHandler<UpdateJokeStateCommand>
    {
        private readonly IJokeDbContext _jokeDbContext;
        private readonly IMapper _mapper;

        public UpdateJokeStateCommandHandler(IJokeDbContext jokeDbContext, IMapper mapper)
        {
            _jokeDbContext = jokeDbContext;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateJokeStateCommand request, CancellationToken cancellationToken)
        {
            var entity = await _jokeDbContext.JokeState
                        .FindAsync(new object[] { request.Id }, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Domain.Entities.JokeState), request.Id);
            }

            entity.CurrentDate = request.CurrentDate;
            entity.JokeId = request.JokeId;

            await _jokeDbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
