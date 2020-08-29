using System.Threading.Tasks;
using PL.BuildingBlocks.Application;

namespace PL.Authorization.Infrastructure
{
    public interface IAuthorizationModule
    {
        Task ExecuteCommandAsync<TResult>(ICommand command);
        Task<TResult> ExecuteQueryAsync<TResult>(IQuery<TResult> query);
    }
}