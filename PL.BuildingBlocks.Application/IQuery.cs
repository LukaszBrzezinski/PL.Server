using MediatR;

namespace PL.BuildingBlocks.Infrastructure
{
    public interface IQuery<out TResult> : IRequest<TResult>
    {

    }
}