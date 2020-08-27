using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace PL.BuildingBlocks.Application
{
    public interface ICommandHandler<in TCommand> : IRequestHandler<TCommand> where TCommand : ICommand
    {
    }
}
