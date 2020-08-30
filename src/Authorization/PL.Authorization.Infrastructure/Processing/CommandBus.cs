using System.Threading.Tasks;
using MediatR;
using PL.BuildingBlocks.Application;
using PL.BuildingBlocks.Application.Processing;

namespace PL.Authorization.Infrastructure.Processing
{
    internal class CommandBus : ICommandBus
    {
        private readonly IMediator _mediator;

        public CommandBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task ExecuteCommandAsync(ICommand command)
        {
            await _mediator.Send(command);
        }

        public async Task<TResult> ExecuteCommandAsync<TResult>(ICommand<TResult> command)
        {
            return await _mediator.Send(command);
        }
    }
}
