using System;
using System.Threading.Tasks;
using PL.BuildingBlocks.Application;

namespace PL.Authorization.Infrastructure
{
    public class AuthorizationModule
    {
        private readonly ICommandBus _commandBus;
        private readonly IQueryBus _queryBus;

        public AuthorizationModule(ICommandBus commandBus, IQueryBus queryBus)
        {
            _commandBus = commandBus;
            _queryBus = queryBus;
        }

        public async Task ExecuteCommandAsync<TResult>(ICommand command)
        {
            await _commandBus.ExecuteCommandAsync(command);
        }

        public async Task<TResult> ExecuteQueryAsync<TResult>(IQuery<TResult> query)
        {
            return await _queryBus.ExecuteQueryAsync(query);
        }

    }
}