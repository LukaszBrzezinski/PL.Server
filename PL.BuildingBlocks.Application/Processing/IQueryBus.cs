using System.Threading.Tasks;

namespace PL.BuildingBlocks.Application.Processing
{
    public interface IQueryBus
    {
        Task<TResult> ExecuteQueryAsync<TResult>(IQuery<TResult> query);
    }
}