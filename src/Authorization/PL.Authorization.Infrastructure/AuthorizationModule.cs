using System;
using System.Threading.Tasks;
using Autofac;
using PL.Authorization.Application;
using PL.BuildingBlocks.Application.Processing;

namespace PL.Authorization.Infrastructure
{
    public class AuthorizationModule : IAuthorizationModule
    {
        public async Task ExecuteCommandAsync(ICommand command)
        {
            using (var scope = AuthorizationCompositionRoot.BeginLifetimeScope())
            {
                var commandBus = scope.Resolve<ICommandBus>();
                await commandBus.ExecuteCommandAsync(command);
            }
        }

        public async Task<TResult> ExecuteCommandAsync<TResult>(ICommand<TResult> command)
        {
            using (var scope = AuthorizationCompositionRoot.BeginLifetimeScope())
            {
                var commandBus = scope.Resolve<ICommandBus>();
                return await commandBus.ExecuteCommandAsync(command);
            }
        }

        public async Task<TResult> ExecuteQueryAsync<TResult>(IQuery<TResult> query)
        {
            using (var scope = AuthorizationCompositionRoot.BeginLifetimeScope())
            {
                var queryBus = scope.Resolve<IQueryBus>();
                return await queryBus.ExecuteQueryAsync(query);
            }
        }
    }
}