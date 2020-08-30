using MediatR;

namespace PL.BuildingBlocks.Application
{
    public interface IQuery<out TResult> : IRequest<TResult>
    {

    }
}