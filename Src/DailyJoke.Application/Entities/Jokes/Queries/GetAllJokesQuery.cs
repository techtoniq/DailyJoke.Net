using AutoMapper;
using AutoMapper.QueryableExtensions;
using DailyJoke.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DailyJoke.Application.Entities.Jokes.Queries
{
    public class GetAllJokesQuery : IRequest<IList<JokeDto>>
    {
    }

    public class GetAllJokesQueryHandler : IRequestHandler<GetAllJokesQuery, IList<JokeDto>>
    {
        private readonly IJokeDbContext _jokeDbContext;
        private readonly IMapper _mapper;

        public GetAllJokesQueryHandler(IJokeDbContext jokeDbContext, IMapper mapper)
        {
            _jokeDbContext = jokeDbContext;
            _mapper = mapper;
        }

        public async Task<IList<JokeDto>> Handle(GetAllJokesQuery request, CancellationToken cancellationToken)
        {
            return await _jokeDbContext.Jokes
                .OrderBy(j => j.UsageCount)
                .AsNoTracking()
                .ProjectTo<JokeDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
