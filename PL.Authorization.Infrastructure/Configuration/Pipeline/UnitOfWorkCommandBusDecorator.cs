using System;
using System.Threading.Tasks;
using PL.BuildingBlocks.Application;
using PL.BuildingBlocks.Infrastructure;

namespace PL.Authorization.Infrastructure.Configuration.Pipeline
{
    internal class UnitOfWorkCommandBusDecorator : ICommandBus
    {
        private readonly ICommandBus _commandBus;
        private readonly IUnitOfWork _unitOfWork;

        public UnitOfWorkCommandBusDecorator(ICommandBus commandBus, IUnitOfWork unitOfWork)
        {
            _commandBus = commandBus;
            _unitOfWork = unitOfWork;
        }

        public async Task ExecuteCommandAsync(ICommand command)
        {
            await _commandBus.ExecuteCommandAsync(command);
            await _unitOfWork.CommitAsync();
        }
    }
}
