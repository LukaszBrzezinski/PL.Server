using System.Threading.Tasks;

namespace PL.BuildingBlocks.Application
{
    public interface IQueryBus
    {
        Task<TResult> ExecuteQueryAsync<TResult>(IQuery<TResult> query);
    }
}