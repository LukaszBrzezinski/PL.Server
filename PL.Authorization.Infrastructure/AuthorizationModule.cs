using System;
using System.Threading.Tasks;
using Autofac;
using PL.BuildingBlocks.Application;

namespace PL.Authorization.Infrastructure
{
    public interface IAuthorizationModule
    {
        Task ExecuteCommandAsync<TResult>(ICommand command);
        Task<TResult> ExecuteQueryAsync<TResult>(IQuery<TResult> query);
    }

    public class AuthorizationModule : IAuthorizationModule
    {
        public async Task ExecuteCommandAsync<TResult>(ICommand command)
        {
            using (var scope = AuthorizationCompositionRoot.BeginLifetimeScope())
            {
                var commandBus = scope.Resolve<ICommandBus>();
                await commandBus.ExecuteCommandAsync(command);
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