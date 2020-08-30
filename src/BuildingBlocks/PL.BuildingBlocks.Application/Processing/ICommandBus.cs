using System.Threading.Tasks;

namespace PL.BuildingBlocks.Application.Processing
{
    public interface ICommandBus
    {
        Task ExecuteCommandAsync(ICommand command);
        Task<TResult> ExecuteCommandAsync<TResult>(ICommand<TResult> command);
    }
}
