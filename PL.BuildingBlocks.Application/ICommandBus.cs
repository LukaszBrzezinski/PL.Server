using System.Threading.Tasks;

namespace PL.BuildingBlocks.Application
{
    public interface ICommandBus
    {
        Task ExecuteCommandAsync(ICommand command);
    }
}
