using System.Threading.Tasks;
using PL.BuildingBlocks.Application;

namespace PL.Authorization.Application
{
    public interface IAuthorizationModule
    {
        Task ExecuteCommandAsync(ICommand command);
        Task<TResult> ExecuteCommandAsync<TResult>(ICommand<TResult> command);
        Task<TResult> ExecuteQueryAsync<TResult>(IQuery<TResult> query);
    }
}