using AutoMapper;
using AutoMapper.QueryableExtensions;
using DailyJoke.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DailyJoke.Application.Entities.JokeState.Queries
{
    public class GetJokeStateQuery : IRequest<JokeStateDto?>
    {
    }

    public class GetJokeStateQueryHandler : IRequestHandler<GetJokeStateQuery, JokeStateDto?>
    {
        private readonly IJokeDbContext _jokeDbContext;
        private readonly IMapper _mapper;

        public GetJokeStateQueryHandler(IJokeDbContext jokeDbContext, IMapper mapper)
        {
            _jokeDbContext = jokeDbContext;
            _mapper = mapper;
        }

        public async Task<JokeStateDto?> Handle(GetJokeStateQuery request, CancellationToken cancellationToken)
        {
            return await _jokeDbContext.JokeState
                .AsNoTracking()
                .ProjectTo<JokeStateDto>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }
    }
}
