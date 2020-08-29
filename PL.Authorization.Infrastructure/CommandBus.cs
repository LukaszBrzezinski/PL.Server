using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using PL.BuildingBlocks.Application;

namespace PL.Authorization.Infrastructure
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
            await _mediator.Publish(command);
        }
    }
}
