using AutoMapper;
using DailyJoke.Application.Interfaces;
using MediatR;

namespace DailyJoke.Application.Entities.JokeState.Commands
{
    public class CreateJokeStateCommand : IRequest<int>
    {
        //public int Id { get; init; }
        public DateTime? CurrentDate { get; init; }
        public int JokeId { get; init; }
    }

    public class CreateJokeStateCommandHandler : IRequestHandler<CreateJokeStateCommand, int>
    {
        private readonly IJokeDbContext _jokeDbContext;
        private readonly IMapper _mapper;

        public CreateJokeStateCommandHandler(IJokeDbContext jokeDbContext, IMapper mapper)
        {
            _jokeDbContext = jokeDbContext;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateJokeStateCommand request, CancellationToken cancellationToken)
        {
            var entity = await _jokeDbContext.JokeState.AddAsync(new Domain.Entities.JokeState() { CurrentDate = request.CurrentDate, JokeId = request.JokeId });
            await _jokeDbContext.SaveChangesAsync(cancellationToken);

            return entity.Entity.Id;
        }
    }
}
