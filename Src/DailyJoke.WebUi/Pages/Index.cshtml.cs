using DailyJoke.Application.Entities.Jokes.Commands;
using DailyJoke.Application.Entities.Jokes.Queries;
using DailyJoke.Application.Entities.JokeState.Commands;
using DailyJoke.Application.Entities.JokeState.Queries;
using DailyJoke.Application.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DailyJoke.WebUi.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IMediator _mediator;
        private readonly IDateTimeProvider _dateTimeProvider;

        public JokeDto Joke { get; internal set; }
        public DateTime Today { get; internal set; }

        public IndexModel(ILogger<IndexModel> logger, IMediator mediator, IDateTimeProvider dateTimeProvider)
        {
            _logger = logger;
            _mediator = mediator;
            _dateTimeProvider = dateTimeProvider;
        }

        public async Task<IActionResult> OnGet()
        {
            Today = _dateTimeProvider.UtcNow.Date;

            var jokeState = await _mediator.Send(new GetJokeStateQuery());

            if(null == jokeState)
            {
                jokeState = new JokeStateDto();
                var jokeStateId = await _mediator.Send(new CreateJokeStateCommand() { CurrentDate = Today });
                jokeState.Id = jokeStateId;
            }

            var jokes = await _mediator.Send(new GetAllJokesQuery());
            if(!jokes.Any())
            {
                // error - no jokes
                return RedirectToPage("Error");
            }

            var currentJoke = jokes.FirstOrDefault(j => j.Id == jokeState.JokeId);

            if(null == currentJoke || jokeState.CurrentDate?.Date != Today)
            {
                currentJoke = jokes.First();
                currentJoke.UsageCount += 1;

                await _mediator.Send(new UpdateJokeCommand() { Id = currentJoke.Id, UsageCount = currentJoke.UsageCount });

                await _mediator.Send(new UpdateJokeStateCommand() { Id = jokeState.Id, JokeId = currentJoke.Id , CurrentDate = Today });
            }

            Joke = currentJoke;

            return Page();
        }
    }
}